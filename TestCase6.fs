// 17.1
let rec pow s n =
    match n with
    | _ when n <= 0 -> ""
    | _ -> s + (pow s (n - 1))


// 17.2
let rec isIthChar (s: string, n: int, c: char) = s.ToString()[n] = c

// 17.3
let rec occFromIth (s: string, n: int, c: char) =
    s |> Seq.filter (fun x' -> x' = c) |> Seq.length

// printfn "%A" (pow ("abC",3))
//
// printfn "%A" (isIthChar ("TestCase", 's', 2))
//
// printfn "%A" (occFromIth ("TestCase", 's', 1))
