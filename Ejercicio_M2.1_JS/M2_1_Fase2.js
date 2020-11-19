const intLeapYear = 1948;

var intYear = 1962;
var intPeriodLeapYear = 4;
var intQtyLeapYear = 0;




for (let i = intLeapYear; i <= intYear; i += intPeriodLeapYear) {
    intQtyLeapYear++;
}
writeQtyLeapYear();

// La creación de la función la ha sugerido el editor

function writeQtyLeapYear() {
    document.getElementById("qtyLeapYear").innerHTML = intQtyLeapYear;
}