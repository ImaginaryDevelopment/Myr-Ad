//------------------------------------------------------------------------------
//        This code was generated by myriad.
//        Changes to this file will be lost when the code is regenerated.
//------------------------------------------------------------------------------
namespace rec Test

module Test1 =
    open Example

    let one (x: Test1) = x.one
    let two (x: Test1) = x.two
    let three (x: Test1) = x.three
    let four (x: Test1) = x.four

    let create (one: int) (two: string) (three: float) (four: float32): Test1 =
        { one = one
          two = two
          three = three
          four = four }

    let map
        (mapone: int -> int)
        (maptwo: string -> string)
        (mapthree: float -> float)
        (mapfour: float32 -> float32)
        (record': Test1)
        =
        { record' with
              one = mapone record'.one
              two = maptwo record'.two
              three = mapthree record'.three
              four = mapfour record'.four }
namespace rec Test

