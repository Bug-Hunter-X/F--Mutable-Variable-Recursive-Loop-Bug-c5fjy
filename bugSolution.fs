let rec loop x y =
    if x > 100 then
        ()
    else
        printfn "%d %d" x y
        loop y (x + y) 