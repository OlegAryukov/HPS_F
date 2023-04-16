module Lesson3

let (|Even|Odd|) input = if input % 2 = 0 then Even else Odd
printfn isEven 2
//let days_in_month = function 