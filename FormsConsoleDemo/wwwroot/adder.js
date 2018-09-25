let button = document.querySelector("#add");
button.onclick = function () {
    let answer = Number(document.querySelector("#op1").value) +
        Number(document.querySelector("#op2").value);
    document.querySelector("#answer").textContent = answer;
    return false;
}