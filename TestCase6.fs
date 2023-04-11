// 17.1
let rec pow = function
    |(s,0) -> s
    |(s, n) -> s + pow(s, n-1)

// 17.2
let rec isIthChar (s: string, c: char, n: int) = s.ToString()[n] = c

// 17.3
let rec occFromIth (s: string, c: char, n: int) =
     s
     |>Seq.filter(fun x' -> x' = c)
     |>Seq.length

// printfn "%A" (pow ("abC",3))
//
// printfn "%A" (isIthChar ("TestCase", 's', 2))
//
// printfn "%A" (occFromIth ("TestCase", 's', 1))