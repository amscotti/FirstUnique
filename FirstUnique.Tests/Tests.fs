module FirstUniqueTests

open FirstUnique

open Xunit

[<Theory>]
[<InlineDataAttribute("abc", 'a')>]
[<InlineDataAttribute("aabc", 'b')>]
[<InlineDataAttribute("aabbc", 'c')>]
[<InlineDataAttribute("abcdefghijklmnopqrstuvwxyz", 'a')>]
[<InlineDataAttribute("abcdefghijklmnopqrstuvwxyza", 'b')>]
[<InlineDataAttribute("abcdefghijklmnopqrstuvwxyzab", 'c')>]
[<InlineDataAttribute("zxybcxzcyba", 'a')>]
[<InlineDataAttribute("你好", '你')>]
[<InlineDataAttribute("你好hello", '你')>]
let ``given a string with a unique character return Sone of the unique character`` (input: string, expected: char) =
    let actual = firstUnique input

    Assert.Equal(Some expected, actual)

[<Theory>]
[<InlineDataAttribute("")>]
[<InlineDataAttribute("aabbcc")>]
[<InlineDataAttribute("abcabc")>]
[<InlineDataAttribute("abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz")>]
[<InlineDataAttribute("你你")>]
[<InlineDataAttribute("你aabcbc你")>]
let ``given a string without a unique character return None`` (input: string) =
    let actual = firstUnique input

    Assert.Equal(None, actual)
