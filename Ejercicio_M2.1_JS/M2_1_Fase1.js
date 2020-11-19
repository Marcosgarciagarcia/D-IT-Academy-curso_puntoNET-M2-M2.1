var strName = 'Marcos';
var strLastName1 = 'Garcia';
var strLastName2 = 'García';

var intDay = 3;
var intMonth = 6;
var intYear = 1962;

document.getElementById("fullName").innerHTML = strLastName1 + " " + strLastName2 + " " + strName;
document.getElementById("born").innerHTML = intDay + "/" + intMonth + "/" + intYear;