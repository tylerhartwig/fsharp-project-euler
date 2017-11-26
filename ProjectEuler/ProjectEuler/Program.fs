// Learn more about F# at http://fsharp.org

open System
open System.Reflection

[<EntryPoint>]
let main argv =
    let moduleInfo = 
        Assembly.GetExecutingAssembly().GetTypes()
        |> Seq.find (fun t -> t.Name = "Solutions")
        
    let method = moduleInfo.GetMethod(String.Format("Problem{0}", argv.[0]))
    let result = method.Invoke(null, [||])
    Console.WriteLine(result);
    0 // return an integer exit code
