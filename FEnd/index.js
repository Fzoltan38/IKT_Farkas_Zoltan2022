var state={users : []};

async function fetchUsers(){
    var userList=await fetch('http://localhost:60227/Service1.svc/getcustomers');
  
    if(!userList.ok){
      alert("Végpont hiba!");
      return;
    }

    var userswcf=await userList.json();
    state.users=userswcf;
    renderUsers();
}

function renderUsers(){
    var userHTML='';
  
    for(var user of state.users){
      userHTML +=`<li class="list-group-item">
      ${user.Id} 
      ${user.Name} 
      ${user.City}
      ${user.Age}<br>
      </li>`
    }
  
    document.getElementById('user-list-container').innerHTML=
    "<ul class='list-group'>"+userHTML+"</ul>";
  }

fetchUsers();