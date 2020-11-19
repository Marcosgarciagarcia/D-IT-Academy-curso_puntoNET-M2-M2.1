const intLeapYear = 1948;

var strName = 'Marcos';
var strLastName1 = 'Garcia';
var strLastName2 = 'García';

var intDay = 3;
var intMonth = 6;
var intYear = 1962;

var intPeriodLeapYear = 4;

var boolBornLeapYear = false;

var arrayLeapYears = [];

var strNoLeapYear = "Mi año de nacimiento no es bisiesto";
var strYesLeapYear = "Mi año de nacimiento es bisiesto";

var concatArray = "";

document.getElementById("fullName").innerHTML = strName + " " + strLastName1 + " " + strLastName2;
document.getElementById("born").innerHTML = addZero(intDay.toString()) + "/" + addZero(intMonth.toString()) + "/" + intYear;

for (let i = intLeapYear; i <= intYear; i += intPeriodLeapYear) {

    arrayLeapYears[arrayLeapYears.length] = i;

    if (i == intYear) { boolBornLeapYear = true; }
}

arrayLeapYears.forEach(readArray);
document.getElementById("leapYears").innerHTML = concatArray;

// Explica por html si nuestro año de nacimiento es bisiesto o no
if (boolBornLeapYear) {
    document.getElementById("isLeapYear").innerHTML = strYesLeapYear;
} else { document.getElementById("isLeapYear").innerHTML = strNoLeapYear; }


// Función que Lee un array y concatena sus elementos dándoles formato 
// para dar la salida por html como una lista
// (Función encontrada en google)

function readArray(value) {
    concatArray = concatArray + value + "<br>";
}


// Función que añade un cero delante del valor enviado (convertido en string)
// en caso de que su longitud sea de 1

function addZero(value) {
    if (value.length == 1) {
        return "0" + value;
    } else { return value; }
}