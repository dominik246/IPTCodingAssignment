﻿async function datePickerSubmit() {
    let form = document.getElementById("datepicker").value;

    let birthday = new Date(form);
    let today = Date.now();

    let diffTime = today - birthday;
    let diffMonths = "You are " + (diffTime / (1000 * 60 * 60 * 24 * 30.417)).toFixed(4) + " months old"; // 30.417 je prosjecni broj svih dana u mjesecima u godini
    let diffHours = "or " + (diffTime / (1000 * 60 * 60)).toFixed(4) + " hours";
    let diffDays = "or " + (diffTime / (1000 * 60 * 60 * 24)).toFixed(4) + " days";
    let diffMinutes = "or " + (diffTime / (1000 * 60)).toFixed(4) + " minutes";
    let diffSeconds = "or " + (diffTime / (1000)).toFixed(4) + " seconds old.";

    let arr = [diffMonths, diffHours, diffDays, diffMinutes, diffSeconds];
    await buildResults(arr);
}

async function buildResults(arr) {
    let container = document.getElementById("results");
    container.innerHTML = "";
    for (let item of arr) {
        let child = document.createElement("p");
        child.innerHTML = item;
        child.className = "paragraphItem";
        container.appendChild(child);
    }
}