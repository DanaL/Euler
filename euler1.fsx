// Just recurse through the numbers keeping a running total
//  TIL: F# requires to you specify when a function is recursive
let rec sum35(total, curr) = 
    if curr >= 1000 then total
    elif curr % 3 = 0 || curr % 5 = 0 then sum35(total + curr, curr + 1)
    else sum35(total, curr + 1)

let res = sum35(0, 1)
printf "%d\n" res

// Alternatively I can just generate a sequence and sum it!
let s = seq { for n in 1 .. 999 do if n % 3 = 0 || n % 5 = 0 then yield n }
let res2 = Seq.sum s
printf "%d\n" res2



