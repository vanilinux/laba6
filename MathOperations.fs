module MathOperations

open System

let add (a: float) (b: float) = a + b
let subtract (a: float) (b: float) = a - b
let multiply (a: float) (b: float) = a * b
let divide (a: float) (b: float) = 
    if b = 0.0 then Error "Ошибка: деление на ноль" 
    else Ok (a / b)

let power (a: float) (b: float) = Math.Pow(a, b)
let squareRoot (a: float) = 
    if a < 0.0 then Error "Ошибка: корень из отрицательного числа" 
    else Ok (Math.Sqrt(a))

let degreesToRadians (degrees: float) = degrees * Math.PI / 180.0
let sinDeg (degrees: float) = Math.Sin (degreesToRadians degrees)
let cosDeg (degrees: float) = Math.Cos (degreesToRadians degrees)
let tanDeg (degrees: float) = Math.Tan (degreesToRadians degrees)