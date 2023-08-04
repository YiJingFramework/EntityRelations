﻿using YiJingFramework.PrimitiveTypes;
using YiJingFramework.PrimitiveTypes.GuaWithFixedCount;

namespace YiJingFramework.EntityRelations.GuaCharacters;
internal static class GuaToCharacterTables
{
    // Generated in project GuaToCharacterGenerating

    public static char SwitchToUnicodeChar(GuaHexagram gua)
    {
        return gua.AsGua().ToBytes()[0] switch {
            64 => '\u4dc1',
            96 => '\u4dd6',
            80 => '\u4dc7',
            112 => '\u4dd3',
            72 => '\u4dcf',
            104 => '\u4de2',
            88 => '\u4dec',
            120 => '\u4dcb',
            68 => '\u4dce',
            100 => '\u4df3',
            84 => '\u4de6',
            116 => '\u4df4',
            76 => '\u4dfd',
            108 => '\u4df7',
            92 => '\u4dde',
            124 => '\u4de0',
            66 => '\u4dc6',
            98 => '\u4dc3',
            82 => '\u4ddc',
            114 => '\u4dfa',
            74 => '\u4de7',
            106 => '\u4dff',
            90 => '\u4dee',
            122 => '\u4dc5',
            70 => '\u4ded',
            102 => '\u4dd1',
            86 => '\u4def',
            118 => '\u4df8',
            78 => '\u4ddf',
            110 => '\u4df1',
            94 => '\u4ddb',
            126 => '\u4deb',
            65 => '\u4dd7',
            97 => '\u4dda',
            81 => '\u4dc2',
            113 => '\u4de9',
            73 => '\u4df2',
            105 => '\u4dd4',
            89 => '\u4dd0',
            121 => '\u4dd8',
            69 => '\u4de3',
            101 => '\u4dd5',
            85 => '\u4dfe',
            117 => '\u4de4',
            77 => '\u4df6',
            109 => '\u4ddd',
            93 => '\u4df0',
            125 => '\u4dcc',
            67 => '\u4dd2',
            99 => '\u4de8',
            83 => '\u4dfb',
            115 => '\u4dfc',
            75 => '\u4df5',
            107 => '\u4de5',
            91 => '\u4df9',
            123 => '\u4dc9',
            71 => '\u4dca',
            103 => '\u4dd9',
            87 => '\u4dc4',
            119 => '\u4dc8',
            79 => '\u4de1',
            111 => '\u4dcd',
            95 => '\u4dea',
            127 => '\u4dc0',
            _ => throw new Exception(
                "This should not happen in any cases. " +
                "Please contact us to report the problem."),
        };
    }

    public static GuaHexagram SwitchFromUnicodeChar(int hexagramDifference)
    {
        var yang = Yinyang.Yang;
        var yin = Yinyang.Yin;
        return hexagramDifference switch {
            0 => new GuaHexagram(yang, yang, yang, yang, yang, yang),
            1 => new GuaHexagram(yin, yin, yin, yin, yin, yin),
            2 => new GuaHexagram(yang, yin, yin, yin, yang, yin),
            3 => new GuaHexagram(yin, yang, yin, yin, yin, yang),
            4 => new GuaHexagram(yang, yang, yang, yin, yang, yin),
            5 => new GuaHexagram(yin, yang, yin, yang, yang, yang),
            6 => new GuaHexagram(yin, yang, yin, yin, yin, yin),
            7 => new GuaHexagram(yin, yin, yin, yin, yang, yin),
            8 => new GuaHexagram(yang, yang, yang, yin, yang, yang),
            9 => new GuaHexagram(yang, yang, yin, yang, yang, yang),
            10 => new GuaHexagram(yang, yang, yang, yin, yin, yin),
            11 => new GuaHexagram(yin, yin, yin, yang, yang, yang),
            12 => new GuaHexagram(yang, yin, yang, yang, yang, yang),
            13 => new GuaHexagram(yang, yang, yang, yang, yin, yang),
            14 => new GuaHexagram(yin, yin, yang, yin, yin, yin),
            15 => new GuaHexagram(yin, yin, yin, yang, yin, yin),
            16 => new GuaHexagram(yang, yin, yin, yang, yang, yin),
            17 => new GuaHexagram(yin, yang, yang, yin, yin, yang),
            18 => new GuaHexagram(yang, yang, yin, yin, yin, yin),
            19 => new GuaHexagram(yin, yin, yin, yin, yang, yang),
            20 => new GuaHexagram(yang, yin, yin, yang, yin, yang),
            21 => new GuaHexagram(yang, yin, yang, yin, yin, yang),
            22 => new GuaHexagram(yin, yin, yin, yin, yin, yang),
            23 => new GuaHexagram(yang, yin, yin, yin, yin, yin),
            24 => new GuaHexagram(yang, yin, yin, yang, yang, yang),
            25 => new GuaHexagram(yang, yang, yang, yin, yin, yang),
            26 => new GuaHexagram(yang, yin, yin, yin, yin, yang),
            27 => new GuaHexagram(yin, yang, yang, yang, yang, yin),
            28 => new GuaHexagram(yin, yang, yin, yin, yang, yin),
            29 => new GuaHexagram(yang, yin, yang, yang, yin, yang),
            30 => new GuaHexagram(yin, yin, yang, yang, yang, yin),
            31 => new GuaHexagram(yin, yang, yang, yang, yin, yin),
            32 => new GuaHexagram(yin, yin, yang, yang, yang, yang),
            33 => new GuaHexagram(yang, yang, yang, yang, yin, yin),
            34 => new GuaHexagram(yin, yin, yin, yang, yin, yang),
            35 => new GuaHexagram(yang, yin, yang, yin, yin, yin),
            36 => new GuaHexagram(yang, yin, yang, yin, yang, yang),
            37 => new GuaHexagram(yang, yang, yin, yang, yin, yang),
            38 => new GuaHexagram(yin, yin, yang, yin, yang, yin),
            39 => new GuaHexagram(yin, yang, yin, yang, yin, yin),
            40 => new GuaHexagram(yang, yang, yin, yin, yin, yang),
            41 => new GuaHexagram(yang, yin, yin, yin, yang, yang),
            42 => new GuaHexagram(yang, yang, yang, yang, yang, yin),
            43 => new GuaHexagram(yin, yang, yang, yang, yang, yang),
            44 => new GuaHexagram(yin, yin, yin, yang, yang, yin),
            45 => new GuaHexagram(yin, yang, yang, yin, yin, yin),
            46 => new GuaHexagram(yin, yang, yin, yang, yang, yin),
            47 => new GuaHexagram(yin, yang, yang, yin, yang, yin),
            48 => new GuaHexagram(yang, yin, yang, yang, yang, yin),
            49 => new GuaHexagram(yin, yang, yang, yang, yin, yang),
            50 => new GuaHexagram(yang, yin, yin, yang, yin, yin),
            51 => new GuaHexagram(yin, yin, yang, yin, yin, yang),
            52 => new GuaHexagram(yin, yin, yang, yin, yang, yang),
            53 => new GuaHexagram(yang, yang, yin, yang, yin, yin),
            54 => new GuaHexagram(yang, yin, yang, yang, yin, yin),
            55 => new GuaHexagram(yin, yin, yang, yang, yin, yang),
            56 => new GuaHexagram(yin, yang, yang, yin, yang, yang),
            57 => new GuaHexagram(yang, yang, yin, yang, yang, yin),
            58 => new GuaHexagram(yin, yang, yin, yin, yang, yang),
            59 => new GuaHexagram(yang, yang, yin, yin, yang, yin),
            60 => new GuaHexagram(yang, yang, yin, yin, yang, yang),
            61 => new GuaHexagram(yin, yin, yang, yang, yin, yin),
            62 => new GuaHexagram(yang, yin, yang, yin, yang, yin),
            63 => new GuaHexagram(yin, yang, yin, yang, yin, yang),
            _ => throw new Exception(
                "This should not happen in any cases. " +
                "Please contact us to report the problem."),
        };
    }
}