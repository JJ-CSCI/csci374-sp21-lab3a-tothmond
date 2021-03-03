module Assignment

// DO NOT MODIFY LEFT PART OF `LET` OPERATOR

// Define following distance unit transformations
let inchToMillimeter v = 
     v * 25.4

let footToInch x =
    x * 12.0
let yardToFoot v =
    v * 3.0

let mileToYard mile =
    mile * 1760.0

(*
Use ONLY above functions and the forward pipe operator, `|>`,  to define the following unit transformation

Forward pipe operator passes the result of the left side to the function on the right side.
*)
let yardToMillimeter y =
    yardToFoot y |> footToInch |> inchToMillimeter

// Define the curried function `divBy1000` that has the signature `float -> float -> float`
let divBy1000 =
    let subfunction x = x/1000.0
    subfunction

(*
Use ONLY above functions to define the following two functions. DO NOT CHANGE SIGNATURES!
*)
let millimeterToMeter n =
   divBy1000 n
let meterToKilometer =
    let subfunction x = divBy1000 x
    subfunction

(*
Use above functions and function composition operator, `>>`, to define the following unit transformations

Forward composition operator composes two functions into one.
*)
let millimeterToKilometer =
    let subfunction  = millimeterToMeter >> meterToKilometer 
    subfunction 

let inchToMeter =
    let subfunction = inchToMillimeter >> millimeterToMeter
    subfunction

let yardToKilometer =
    let subfunction = yardToMillimeter >> millimeterToKilometer
    subfunction

let mileToMeter =
    let subfunction = mileToYard >> yardToMillimeter >>millimeterToMeter
    subfunction
    
      
    


// Define following weight unit transformations
let ounceToGram v =
    v * 28.349523125

let poundToOunce p =
    p * 16.0

let shortTonToPound t =
    t * 2000.0


(*
Use ONLY above functions to define the following two functions. DO NOT CHANGE SIGNATURES!
*)

let gramToKilogram g =
   divBy1000 g

(*
Use ONLY above functions and function composition operator, `>>`, to define the following unit transformations

Forward composition operator composes two functions into one.
*)

let gramToMetricTon =
    let subfunction = divBy1000 >> divBy1000
    subfunction

let poundToKilogram =
    let subfunction = poundToOunce >> ounceToGram >> gramToKilogram
    subfunction

let shortTonToMetricTon =
    let subfunction = shortTonToPound >> poundToKilogram >> divBy1000
    subfunction
