/*
 Write a script that enters the coefficients a, b and c
 of a quadratic equation
 a*x2 + b*x + c = 0
 and calculates and prints its real roots. Note that
 quadratic equations may have 0, 1 or 2 real roots.
 */

function quadraticEquation(form) {
    var a = eval(form.a.value);
    var b = eval(form.b.value);
    var c = eval(form.c.value);

    var x1 = -b / 2 / a + Math.pow(Math.pow(b, 2) - 4 * a * c, 0.5) / 2 / a;
    var x2 = -b / 2 / a - Math.pow(Math.pow(b, 2) - 4 * a * c, 0.5) / 2 / a;

    form.x1.value = x1;
    form.x2.value = x2;

    if (form.x1.value == "NaN") form.x1.value = "Imaginary!";
    if (form.x2.value == "NaN") form.x2.value = "Imaginary!";
}