module FirstUnique

let firstUnique (input: string): char option =
    input
    |> Seq.countBy id
    |> Seq.filter (snd >> (=) 1)
    |> Seq.map fst
    |> Seq.tryHead
