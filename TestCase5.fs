// module TestCase5

// 16.1
let notDivisible = function
    | n, m -> m % n = 0 
// 16.2
let  prime = function
    |n -> 
    let rec check i =
        i > n/2 || (n % i <> 0 && check (i + 1))
    check 2

// printfn "%A" (notDivisible (5,3))
// printfn "%A" (prime 15)