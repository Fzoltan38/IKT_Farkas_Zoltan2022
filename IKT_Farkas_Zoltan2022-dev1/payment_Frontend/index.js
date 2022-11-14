var state = false;

document.getElementById("stateButton").onclick = function (){
    if(state){
        state=!state;
        document.getElementById('idField').innerHTML="";
    }
    else{
        state=!state;
        var contentText=`
        ID: <input type='number' id='idNumber'><br>
        `;
        document.getElementById('idField').innerHTML=contentText;     
    }
}

document.getElementById('forms').onsubmit =function (event){
    event.preventDefault();
    var nev=event.target.elements.nev.value;
    var varos=event.target.elements.varos.value;
    var kor=event.target.elements.kor.value;

    if(!state){
        let bodyCustomer=JSON.stringify({
            Name: nev,
            Age: kor,
            City: varos
          });
          
        putCustomer(bodyCustomer);
    }
    else{     
        let azon=event.target.elements.idNumber.value;
        let bodyyCustomer=JSON.stringify({
            Id: azon,
            Name: nev,
            Age: kor,
            City: varos
          });
        
        updateCustomer(bodyyCustomer);
    }
}

document.getElementById('button2').onclick = function(){
    id=document.getElementById('number2').value;
    deletCustomer(id);
   
}

async function deletCustomer(id){
    var url='http://localhost:60227/Service1.svc/deletecustomer/'+id;
    var delUser=await fetch(url,{
        method : "DELETE",
        headers : {
            'Content-type': 'application/json'
        }
    });
    
    if(!delUser.ok){
        alert("Delete hiba!");
        return;
    }

    var httpMessage=await delUser.json();

    alert(httpMessage);

    getCustomers();
}
async function updateCustomer(bodyCustomer){
    
    var url='http://localhost:60227/Service1.svc/postcustomerbody';
    var upUser=await fetch(url,{
        method: "POST",
        body: bodyCustomer,
        headers:{
            'Content-type':'application/json'
        }

    });

    if(!upUser.ok){
        alert("Update hiba!");
        return;
    }

    var upResult=await upUser.json();

    alert(upResult);

    getCustomers();

}
async function putCustomer(bodyCustomer){
   
    var url='http://localhost:60227/Service1.svc/putcustomer';
    var putUser=await fetch(url,{
        method: "POST",
        body: bodyCustomer,
        headers: {
            'Content-Type': 'application/json'
        }
    })

    if(!putUser.ok){
        alert("POST végpont hiba!");
        return;
    }

    var httpMessage=await putUser.json();

    alert(httpMessage);

    getCustomers();
} 

async function getCustomers(){

    var url='http://localhost:60227/Service1.svc/getcustomers';
    var userList = await fetch(url); 

    if(!userList.ok){
        alert("GET végpont hiba!");
        return;
    }

    var users=await userList.json();

    renderUsers(users);

}

function renderUsers(users){
    var contentText='';

    for (var item of users) {
        contentText+=`<li>
        ${item.Id} 
        ${item.Name}
        ${item.Age}
        ${item.City}<br>
        </li>`;
    }

    document.getElementById("uList").innerHTML="<ul>"+contentText+"</ul>"
}

getCustomers();
