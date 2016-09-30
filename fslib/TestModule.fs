namespace TestModule

open UnityEngine

type MyMonobehaviour2() =
    inherit MonoBehaviour()
    member this.Update() =
        Debug.Log "update"
