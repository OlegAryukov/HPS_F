// 17.1
let rec pow (s: string, n:int) =
    match n with
    | _ when n <= 0 -> ""
    | _ -> s + (pow (s, (n - 1)))


// 17.2
let rec isIthChar (s: string, n: int, c: char) = s[n] = c

// 17.3
let rec occFromIth (s: string, n: int, c: char) =
    s[n..] |> Seq.filter (fun x' -> x' = c) |> Seq.length

printfn "%A" (pow ("abC",3))

printfn "%A" (isIthChar ("TestCase", 2, 's'))

printfn "%A" (occFromIth ("TestCase", 1, 's'))
