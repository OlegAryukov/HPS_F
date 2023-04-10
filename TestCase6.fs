// module TestCase6

// 17.1
let rec pow = function
    |(s,0) -> s
    |(s, n) -> s + pow(s, n-1)

// 17.2
let rec isIthChar = function
    |(s,c,n) -> s.ToString()[n] = c

// 17.3
let rec occFromIth = function
     |(s,c,n) -> 
            s.ToString()[n..] 
            |>Seq.filter(fun x' -> x' = c)
            |>Seq.length
     // |(s,n,c) when s.ToString().Length = 0 -> n
     // |(s,n,c) when isIthChar(s.ToString()[..n],c,0) -> occFromIth(s.ToString().[..2], )


// printfn "%A" (pow ("abC",3))
//
// printfn "%A" (isIthChar ("TestCase", 's', 2))
//
// printfn "%A" (occFromIth ("TestCase", 's', 1))