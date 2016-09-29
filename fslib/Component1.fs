namespace fslib

open UnityEngine

type Class1() = 
    member this.X = "F#"

type MyBehaviour() =
    inherit MonoBehaviour()
    member this.x = 1
    member this.Start() = Debug.Log "hello from F#"