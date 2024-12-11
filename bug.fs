let mutable x = 0
let mutable y = 1
let rec loop x y =
    if x > 100 then
        ()
    else
        let temp = x
        x <- y
        y <- temp + y
        printfn "%d %d" x y
        loop x y
loop x y