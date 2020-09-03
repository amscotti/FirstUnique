open FirstUnique

[<EntryPoint>]
let main argv =
    match argv |> Seq.tryHead |> Option.bind firstUnique with
    | Some c -> printfn "First unique letter is '%c'" c
    | None -> printfn "Didn't find any unique letter"
    
    0 // return an integer exit code
