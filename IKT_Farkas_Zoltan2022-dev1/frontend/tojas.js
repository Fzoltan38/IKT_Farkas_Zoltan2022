for (let i = 100; i>=1;i--) {
    let emelet = document.createElement("div");
document.body.appendChild(emelet);
emelet.style.backgroundColor = "#e0e0e0";
emelet.style.border = "25px";
emelet.style.width = "100px"
emelet.innerHTML = i;
emelet.id = i;
}

document.getElementsById().onclick = function() {
    console.log(document.getElementsByTagName("div").innerHTML) 
}
console.log(document.getElementsByTagName("div").innerHTML);