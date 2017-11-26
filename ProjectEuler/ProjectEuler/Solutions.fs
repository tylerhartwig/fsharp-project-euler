namespace Fsharp.ProjectEuler.Solutions

module Solutions = 
    let Problem1() = 
        Seq.initInfinite(fun i -> i) 
        |> Seq.filter(fun x -> (x % 3 = 0 || x % 5 = 0))
        |> Seq.takeWhile(fun x -> x < 1000)
        |> Seq.sum
        
    let Problem2() =
        (0, 1) 
        |> Seq.unfold(fun (a, b) -> Some(a + b, (b, a + b)))
        |> Seq.filter(fun x -> x % 2 = 0)
        |> Seq.takeWhile(fun x -> x < 4000000) 
        |> Seq.sum
        