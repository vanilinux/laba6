open System
open MathOperations

let readNumber (prompt: string) =
    printfn "%s" prompt
    match Double.TryParse(Console.ReadLine()) with
    | true, num -> Some num
    | false, _ -> 
        printfn "Некорректный ввод. Пожалуйста, введите число."
        None

let rec mainMenu() =
    printfn "\nКалькулятор"
    printfn "1. Сложение"
    printfn "2. Вычитание"
    printfn "3. Умножение"
    printfn "4. Деление"
    printfn "5. Возведение в степень"
    printfn "6. Квадратный корень"
    printfn "7. Синус угла"
    printfn "8. Косинус угла"
    printfn "9. Тангенс угла"
    printfn "0. Выход"
    printf "Выберите операцию: "

    match Console.ReadLine() with
    | "1" ->
        match readNumber "Введите первое число:", readNumber "Введите второе число:" with
        | Some a, Some b -> printfn "Результат: %.2f" (add a b)
        | _ -> ()
        mainMenu()

    | "2" ->
        match readNumber "Введите первое число:", readNumber "Введите второе число:" with
        | Some a, Some b -> printfn "Результат: %.2f" (subtract a b)
        | _ -> ()
        mainMenu()

    | "3" -> 
        match readNumber "Введите первое число:", readNumber "Введите второе число:" with
        | Some a, Some b -> printfn "Результат: %.2f" (multiply a b)
        | _ -> ()
        mainMenu()

    | "4" -> 
        match readNumber "Введите делимое:", readNumber "Введите делитель:" with
        | Some a, Some b -> 
            match divide a b with
            | Ok result -> printfn "Результат: %.2f" result
            | Error msg -> printfn "%s" msg
        | _ -> ()
        mainMenu()

    | "5" -> 
        match readNumber "Введите основание:", readNumber "Введите показатель степени:" with
        | Some a, Some b -> printfn "Результат: %.2f" (power a b)
        | _ -> ()
        mainMenu()

    | "6" -> 
        match readNumber "Введите число:" with
        | Some a -> 
            match squareRoot a with
            | Ok result -> printfn "Результат: %.2f" result
            | Error msg -> printfn "%s" msg
        | _ -> ()
        mainMenu()

    | "7" -> 
        match readNumber "Введите угол в градусах:" with
        | Some a -> printfn "Результат: %.2f" (sinDeg a)
        | _ -> ()
        mainMenu()

    | "8" ->
        match readNumber "Введите угол в градусах:" with
        | Some a -> printfn "Результат: %.2f" (cosDeg a)
        | _ -> ()
        mainMenu()

    | "9" -> 
        match readNumber "Введите угол в градусах:" with
        | Some a -> printfn "Результат: %.2f" (tanDeg a)
        | _ -> ()
        mainMenu()

    | "0" ->
        printfn "До свидания!"

    | _ -> 
        printfn "Некорректный выбор. Попробуйте снова."
        mainMenu()

[<EntryPoint>]
let main argv =
    mainMenu()
    0