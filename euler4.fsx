let rec isPalinedrome(a:string, m, n) =
    if m >= n then true
    elif a.[m] <> a.[n] then false
    else isPalinedrome(a, m+1, n-1)

// This isn't very idiomatic F# but some problems are just phrased nicely
// as iterative solutions. I do like my isPalindrome() check, though. Reminds
// me of a lot of the execises in the Little Schemer
let mutable palinedromes = [] 
for x = 100 to 999 do
    for y = 999 downto x do
        let z = x * y
        let s = string z
        let is_p = isPalinedrome(s, 0, s.Length-1)
        if is_p then palinedromes <- [z] |> List.append palinedromes

let m = List.max palinedromes
printf "%d\n" m
