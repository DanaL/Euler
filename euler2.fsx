
// Every third Fibonacci number is even, and I tried to think of a way to cleanly just select every 3rd item in
// the sequence to avoid the "divisible by 2" test but I couldn't think of anything elegant. (I'm still new at this
// F# business)
// And you can straight up just calculate the answer, of course, but I don't remember how that stuff works :P
let fibseq = Seq.unfold (fun (a, b) -> if (a + b > 4000000) then None else Some(a + b, (b, (a + b)))) (0, 1)
let sum = seq { for n in fibseq do if n % 2 = 0 then yield n} |> Seq.sum
seq { for n in fibseq do if n % 2 = 0 then yield n} |> Seq.sum |> printf "%d\n"
