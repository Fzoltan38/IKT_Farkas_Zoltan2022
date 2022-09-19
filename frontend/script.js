/*
1. doboz:
Kattintásra adjunk hozzá egy "blur" nevű class attribútumot, majd újabb kattintásra vegyük
le róla azt.
*/

/*
1) Beazonosítod
2) Eventet keresünk
3) Mi történjen?
*/

//state
let isBlured = false;

//action
document.getElementById("element-one").onclick = function() {
    //state change
    isBlured = !isBlured;
    console.log(isBlured);
    
    //render
    if (isBlured) {
        document.getElementById("element-one").classList.add("blur");
    } else {
        document.getElementById("element-one").classList.remove("blur");
    }
}
