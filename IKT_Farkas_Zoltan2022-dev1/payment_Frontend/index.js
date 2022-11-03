document.getElementById('form1').onsubmit=function (event){
  
    event.preventDefault();
    var nev=event.target.elements.nev.value;
    var kor=event.target.elements.kor.value;
    var varos=event.target.elements.varos.value;

    var body=JSON.stringify({
      Name: nev,
      Age: kor,
      City: varos
    });

    putCustomer(body);
}


async function putCustomer(){
   
    var url='http://localhost:60227/Service1.svc/putcustomer';
    var putUser=await fetch(url,{
        method: "PUT",
        body: body,
        headers: {
            'Content-Type': 'application/json'
        }
    })
} 

async function getCustomers(){

    var url='http://localhost:60227/Service1.svc/getcustomers';
    var userList = await fetch(url); 

    if(!userList.ok){
        alert("Végpont hiba!");
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