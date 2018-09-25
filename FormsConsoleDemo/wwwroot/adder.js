let button = document.querySelector("#add");
button.onclick = function () {
    let answer = Number(document.querySelector("#op1").value) +
        Number(document.querySelector("#op2").value);
    document.querySelector("#answer").textContent = answer;
    return false;
};

// Gender selector - radio buttons
let selectGender = function () {
    let gender = document.querySelector("input[type=radio]:checked").value;
    document.querySelector("#selected").innerHTML = `Current selection: <b> ${gender} </b>`;
};

let selectGen = document.querySelector("#genderselect");
selectGen.onclick = selectGender;
