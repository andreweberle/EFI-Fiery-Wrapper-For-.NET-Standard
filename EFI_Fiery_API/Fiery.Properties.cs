using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFI_Fiery_API
{
    public class FieryPrinterProperties
    {
        public class PrinterProperties
        {
            [JsonProperty("time")]
            public DateTime Time { get; set; }

            [JsonProperty("Data")]
            public Data Data { get; set; }
        }

        public class Data
        {
            [JsonProperty("totalItems")]
            public int TotalItems { get; set; }

            [JsonProperty("kind")]
            public string Kind { get; set; }

            [JsonProperty("items")]
            public List<Item> Items { get; set; }

            [JsonProperty("_links")]
            public List<Links> Links { get; set; }
        }

        public class Item
        {
            public string id { get; set; }
            public object value { get; set; }
            public string[] scopes { get; set; }
            public object[] uneditablekeys { get; set; }
            public object[] values { get; set; }
            public Value_Attributes value_attributes { get; set; }
            public Constraints constraints { get; set; }
            public string group { get; set; }
            public string ppdtype { get; set; }
            public string query { get; set; }
            public string version { get; set; }
            public string polymorphic { get; set; }
            public string editable { get; set; }
            public string length { get; set; }
            public string Encrypt { get; set; }
            public string Password { get; set; }
            public string UTF8 { get; set; }
            public string Hyphen { get; set; }
            public string MultiComma { get; set; }
            public string Numeric { get; set; }
        }

        public class Value_Attributes
        {
            public _00 _00 { get; set; }
            public _120 _120 { get; set; }
            public _200 _200 { get; set; }
            public _210 _210 { get; set; }
            public _250 _250 { get; set; }
            public _350 _350 { get; set; }
            public _400 _400 { get; set; }
            public _490 _490 { get; set; }
            public _50 _50 { get; set; }
            public _500 _500 { get; set; }
            public _520 _520 { get; set; }
            public _540 _540 { get; set; }
            public _550 _550 { get; set; }
            public _560 _560 { get; set; }
            public _565 _565 { get; set; }
            public _570 _570 { get; set; }
            public _580 _580 { get; set; }
            public _584 _584 { get; set; }
            public _585 _585 { get; set; }
            public _586 _586 { get; set; }
            public _590 _590 { get; set; }
            public _600 _600 { get; set; }
            public _610 _610 { get; set; }
            public _611 _611 { get; set; }
            public _620 _620 { get; set; }
            public _650 _650 { get; set; }
            public _700 _700 { get; set; }
            public _900 _900 { get; set; }
            public _950 _950 { get; set; }
            public False False { get; set; }
            public True True { get; set; }
            public GA2 GA2 { get; set; }
            public Stacker1 Stacker1 { get; set; }
            public Stacker2 Stacker2 { get; set; }
            public Stacker3 Stacker3 { get; set; }
            public Stacker4 Stacker4 { get; set; }
            public Toptray1 TopTray1 { get; set; }
            public Toptray2 TopTray2 { get; set; }
            public Toptray3 TopTray3 { get; set; }
            public Toptray4 TopTray4 { get; set; }
            public Blue Blue { get; set; }
            public Clear Clear { get; set; }
            public Green Green { get; set; }
            public Orange Orange { get; set; }
            public White White { get; set; }
            public Feeder1 Feeder1 { get; set; }
            public Feeder2 Feeder2 { get; set; }
            public Feeder3 Feeder3 { get; set; }
            public Feeder4 Feeder4 { get; set; }
            public Feeder5 Feeder5 { get; set; }
            public Feeder6 Feeder6 { get; set; }
            public Inserter1 Inserter1 { get; set; }
            public Inserter2 Inserter2 { get; set; }
            public Invocation invocation { get; set; }
            public All All { get; set; }
            public Even Even { get; set; }
            public Odd Odd { get; set; }
            public Range1 Range1 { get; set; }
            public NO NO { get; set; }
            public YES YES { get; set; }
            public Child _ { get; set; }
            public Usefilename UseFilename { get; set; }
            public Usepstitle UsePSTitle { get; set; }
            public Hold Hold { get; set; }
            public Printndelete PrintNDelete { get; set; }
            public Ripnhold RipNHold { get; set; }
            public Colorcodedjob ColorCodedJob { get; set; }
            public Reportconcise ReportConcise { get; set; }
            public Testpage TestPage { get; set; }
            public Plain Plain { get; set; }
            public Preprinted Preprinted { get; set; }
            public Tabpaper1 Tabpaper1 { get; set; }
            public Tabpaper2 Tabpaper2 { get; set; }
            public Tabstock Tabstock { get; set; }
            public Transparency Transparency { get; set; }
            public Userdefined UserDefined { get; set; }
            public Gsm_101103 gsm_101103 { get; set; }
            public Gsm_104106 gsm_104106 { get; set; }
            public Gsm_107109 gsm_107109 { get; set; }
            public Gsm_110112 gsm_110112 { get; set; }
            public Gsm_113115 gsm_113115 { get; set; }
            public Gsm_116118 gsm_116118 { get; set; }
            public Gsm_119121 gsm_119121 { get; set; }
            public Gsm_122124 gsm_122124 { get; set; }
            public Gsm_125127 gsm_125127 { get; set; }
            public Gsm_128130 gsm_128130 { get; set; }
            public Gsm_131133 gsm_131133 { get; set; }
            public Gsm_134136 gsm_134136 { get; set; }
            public Gsm_137139 gsm_137139 { get; set; }
            public Gsm_140142 gsm_140142 { get; set; }
            public Gsm_143145 gsm_143145 { get; set; }
            public Gsm_146148 gsm_146148 { get; set; }
            public Gsm_149151 gsm_149151 { get; set; }
            public Gsm_152154 gsm_152154 { get; set; }
            public Gsm_155157 gsm_155157 { get; set; }
            public Gsm_158160 gsm_158160 { get; set; }
            public Gsm_161163 gsm_161163 { get; set; }
            public Gsm_164166 gsm_164166 { get; set; }
            public Gsm_167169 gsm_167169 { get; set; }
            public Gsm_170172 gsm_170172 { get; set; }
            public Gsm_173175 gsm_173175 { get; set; }
            public Gsm_176178 gsm_176178 { get; set; }
            public Gsm_179181 gsm_179181 { get; set; }
            public Gsm_180530 gsm_180530 { get; set; }
            public Gsm_182184 gsm_182184 { get; set; }
            public Gsm_185187 gsm_185187 { get; set; }
            public Gsm_188190 gsm_188190 { get; set; }
            public Gsm_191193 gsm_191193 { get; set; }
            public Gsm_194196 gsm_194196 { get; set; }
            public Gsm_197199 gsm_197199 { get; set; }
            public Gsm_200202 gsm_200202 { get; set; }
            public Gsm_203205 gsm_203205 { get; set; }
            public Gsm_206208 gsm_206208 { get; set; }
            public Gsm_209211 gsm_209211 { get; set; }
            public Gsm_212214 gsm_212214 { get; set; }
            public Gsm_215217 gsm_215217 { get; set; }
            public Gsm_218220 gsm_218220 { get; set; }
            public Gsm_221223 gsm_221223 { get; set; }
            public Gsm_224226 gsm_224226 { get; set; }
            public Gsm_227229 gsm_227229 { get; set; }
            public Gsm_230232 gsm_230232 { get; set; }
            public Gsm_233235 gsm_233235 { get; set; }
            public Gsm_236238 gsm_236238 { get; set; }
            public Gsm_239241 gsm_239241 { get; set; }
            public Gsm_242244 gsm_242244 { get; set; }
            public Gsm_245247 gsm_245247 { get; set; }
            public Gsm_248250 gsm_248250 { get; set; }
            public Gsm_251253 gsm_251253 { get; set; }
            public Gsm_254256 gsm_254256 { get; set; }
            public Gsm_257259 gsm_257259 { get; set; }
            public Gsm_260262 gsm_260262 { get; set; }
            public Gsm_263265 gsm_263265 { get; set; }
            public Gsm_266268 gsm_266268 { get; set; }
            public Gsm_269271 gsm_269271 { get; set; }
            public Gsm_272274 gsm_272274 { get; set; }
            public Gsm_275277 gsm_275277 { get; set; }
            public Gsm_278280 gsm_278280 { get; set; }
            public Gsm_281283 gsm_281283 { get; set; }
            public Gsm_284286 gsm_284286 { get; set; }
            public Gsm_287289 gsm_287289 { get; set; }
            public Gsm_290292 gsm_290292 { get; set; }
            public Gsm_293295 gsm_293295 { get; set; }
            public Gsm_296298 gsm_296298 { get; set; }
            public Gsm_299301 gsm_299301 { get; set; }
            public Gsm_302304 gsm_302304 { get; set; }
            public Gsm_305307 gsm_305307 { get; set; }
            public Gsm_308310 gsm_308310 { get; set; }
            public Gsm_311313 gsm_311313 { get; set; }
            public Gsm_314316 gsm_314316 { get; set; }
            public Gsm_317319 gsm_317319 { get; set; }
            public Gsm_320322 gsm_320322 { get; set; }
            public Gsm_323325 gsm_323325 { get; set; }
            public Gsm_326328 gsm_326328 { get; set; }
            public Gsm_329331 gsm_329331 { get; set; }
            public Gsm_332334 gsm_332334 { get; set; }
            public Gsm_335337 gsm_335337 { get; set; }
            public Gsm_338340 gsm_338340 { get; set; }
            public Gsm_341343 gsm_341343 { get; set; }
            public Gsm_344346 gsm_344346 { get; set; }
            public Gsm_347349 gsm_347349 { get; set; }
            public Gsm_350 gsm_350 { get; set; }
            public Gsm_6061 gsm_6061 { get; set; }
            public Gsm_6264 gsm_6264 { get; set; }
            public Gsm_6567 gsm_6567 { get; set; }
            public Gsm_6870 gsm_6870 { get; set; }
            public Gsm_7173 gsm_7173 { get; set; }
            public Gsm_7476 gsm_7476 { get; set; }
            public Gsm_7779 gsm_7779 { get; set; }
            public Gsm_8082 gsm_8082 { get; set; }
            public Gsm_8385 gsm_8385 { get; set; }
            public Gsm_8688 gsm_8688 { get; set; }
            public Gsm_8991 gsm_8991 { get; set; }
            public Gsm_9294 gsm_9294 { get; set; }
            public Gsm_9597 gsm_9597 { get; set; }
            public Gsm_98100 gsm_98100 { get; set; }
            public Buff Buff { get; set; }
            public Custom1 Custom1 { get; set; }
            public Custom2 Custom2 { get; set; }
            public Custom3 Custom3 { get; set; }
            public Custom4 Custom4 { get; set; }
            public Custom5 Custom5 { get; set; }
            public Goldenrod Goldenrod { get; set; }
            public Gray Gray { get; set; }
            public Ivory Ivory { get; set; }
            public Pink Pink { get; set; }
            public Red Red { get; set; }
            public Yellow Yellow { get; set; }
            public Regular Regular { get; set; }
            public Rough Rough { get; set; }
            public Semirough SemiRough { get; set; }
            public Smooth Smooth { get; set; }
            public string command { get; set; }
            public bool editable { get; set; }
            public float increment { get; set; }
            public float max { get; set; }
            public float min { get; set; }
            public object[] uneditablekeys { get; set; }
            public Both Both { get; set; }
            public None None { get; set; }
            public Side1 Side1 { get; set; }
            public Glossy Glossy { get; set; }
            public Highgloss HighGloss { get; set; }
            public Matte Matte { get; set; }
            public Satin Satin { get; set; }
            public Semigloss SemiGloss { get; set; }
            public _1 _1 { get; set; }
            public _12X26 _12x26 { get; set; }
            public _1433X26 _1433x26 { get; set; }
            public _143X205 _143x205 { get; set; }
            public _143X225 _143x225 { get; set; }
            public _9X11 _9x11 { get; set; }
            public _9X11r _9x11R { get; set; }
            public A3 A3 { get; set; }
            public A4 A4 { get; set; }
            public A4oversizedtab A4OverSizedTab { get; set; }
            public A4oversizedtabr A4OverSizedTabR { get; set; }
            public A4R A4R { get; set; }
            public B4 B4 { get; set; }
            public B4R B4R { get; set; }
            public Customprintsize CustomPrintSize { get; set; }
            public Fanfoldgermanlegal FanFoldGermanLegal { get; set; }
            public Fanfoldgermanlegalr FanFoldGermanLegalR { get; set; }
            public ISOB3 ISOB3 { get; set; }
            public ISOB4 ISOB4 { get; set; }
            public ISOB4R ISOB4R { get; set; }
            public Legal Legal { get; set; }
            public Legalr LegalR { get; set; }
            public Letter Letter { get; set; }
            public Letterr LetterR { get; set; }
            public SRA3 SRA3 { get; set; }
            public Sameaspagesize SameAsPageSize { get; set; }
            public Tabloid Tabloid { get; set; }
            public Tabloidextra TabloidExtra { get; set; }
            public Custom custom { get; set; }
            public Metric Metric { get; set; }
            public US US { get; set; }
            public Autoselect AutoSelect { get; set; }
            public Postfusertray PostFuserTray { get; set; }
            public Postfusertray2 PostFuserTray2 { get; set; }
            public Postfusertray3 PostFuserTray3 { get; set; }
            public Postfusertray4 PostFuserTray4 { get; set; }
            public Tray1 Tray1 { get; set; }
            public Tray10 Tray10 { get; set; }
            public Tray11 Tray11 { get; set; }
            public Tray12 Tray12 { get; set; }
            public Tray2 Tray2 { get; set; }
            public Tray3 Tray3 { get; set; }
            public Tray4 Tray4 { get; set; }
            public Tray5 Tray5 { get; set; }
            public Tray6 Tray6 { get; set; }
            public Tray7 Tray7 { get; set; }
            public Tray8 Tray8 { get; set; }
            public Tray9 Tray9 { get; set; }
            public Blank Blank { get; set; }
            public Tab Tab { get; set; }
            public Printback PrintBack { get; set; }
            public Printboth PrintBoth { get; set; }
            public Printfront PrintFront { get; set; }
            public Bypass Bypass { get; set; }
            public Documentdef DocumentDEF { get; set; }
            public Stacker Stacker { get; set; }
            public Stackerauto StackerAuto { get; set; }
            public Top Top { get; set; }
            public Top2 Top2 { get; set; }
            public Top3 Top3 { get; set; }
            public Top4 Top4 { get; set; }
            public Toptrayauto TopTrayAuto { get; set; }
            public Firsttolast FirstToLast { get; set; }
            public Lasttofirst LastToFirst { get; set; }
            public Topbottom TopBottom { get; set; }
            public Toptop TopTop { get; set; }
            public A4toletter A4ToLetter { get; set; }
            public Lettertoa4 LetterToA4 { get; set; }
            public Landscape Landscape { get; set; }
            public Portrait Portrait { get; set; }
            public _16ULH _16ULH { get; set; }
            public _16ULV _16ULV { get; set; }
            public _16URH _16URH { get; set; }
            public _16URV _16URV { get; set; }
            public _1UP _1UP { get; set; }
            public _2ULH _2ULH { get; set; }
            public _2ULV _2ULV { get; set; }
            public _2URH _2URH { get; set; }
            public _2URV _2URV { get; set; }
            public _4ULH _4ULH { get; set; }
            public _4ULV _4ULV { get; set; }
            public _4URH _4URH { get; set; }
            public _4URV _4URV { get; set; }
            public _6ULH _6ULH { get; set; }
            public _6ULV _6ULV { get; set; }
            public _6URH _6URH { get; set; }
            public _6URV _6URV { get; set; }
            public _9ULH _9ULH { get; set; }
            public _9ULV _9ULV { get; set; }
            public _9URH _9URH { get; set; }
            public _9URV _9URV { get; set; }
            public Double Double { get; set; }
            public Nestsaddlel NestSaddleL { get; set; }
            public Nestsaddler NestSaddleR { get; set; }
            public Nestsaddlet NestSaddleT { get; set; }
            public Perfect Perfect { get; set; }
            public Perfectright PerfectRight { get; set; }
            public Perfecttop PerfectTop { get; set; }
            public Speed Speed { get; set; }
            public Twoup TwoUp { get; set; }
            public Twoupright TwoUpRight { get; set; }
            public Twouptop TwoUpTop { get; set; }
            public Side2 Side2 { get; set; }
            public Multipagenospine MultiPageNoSpine { get; set; }
            public Preprinted1 PrePrinted { get; set; }
            public Thick Thick { get; set; }
            public Useimageable UseImageable { get; set; }
            public int precision { get; set; }
            public _10 _10 { get; set; }
            public _11 _11 { get; set; }
            public _12 _12 { get; set; }
            public _13 _13 { get; set; }
            public _14 _14 { get; set; }
            public _15 _15 { get; set; }
            public _16 _16 { get; set; }
            public _17 _17 { get; set; }
            public _18 _18 { get; set; }
            public _19 _19 { get; set; }
            public _2 _2 { get; set; }
            public _20 _20 { get; set; }
            public _3 _3 { get; set; }
            public _4 _4 { get; set; }
            public _5 _5 { get; set; }
            public _6 _6 { get; set; }
            public _7 _7 { get; set; }
            public _8 _8 { get; set; }
            public _9 _9 { get; set; }
            public Bottom Bottom { get; set; }
            public Middle Middle { get; set; }
            public Auto Auto { get; set; }
            public Left Left { get; set; }
            public Right Right { get; set; }
            public _2Up_Landscape _2up_Landscape { get; set; }
            public Duplex_Grayscale Duplex_Grayscale { get; set; }
            public Large_Booklet Large_Booklet { get; set; }
            public Small_Booklet Small_Booklet { get; set; }
            public Usesystemdefault UseSystemDefault { get; set; }
            public DEFAULT_MEDIA DEFAULT_MEDIA { get; set; }
            public _﻿FieryIgen5Dceliteg80T160DotMatteDryInkV1f _﻿FieryiGen5DCEliteG80T160DotMatteDryInkv1F { get; set; }
            public _﻿FieryIgen5Dceliteg80T180DotMatteDryInkV1f _﻿FieryiGen5DCEliteG80T180DotMatteDryInkv1F { get; set; }
            public _﻿FieryIgen5Dceliteg80T210DotMatteDryInkV1f _﻿FieryiGen5DCEliteG80T210DotMatteDryInkv1F { get; set; }
            public _﻿FieryIgen5Dceliteg80T250DotMatteDryInkV1f _﻿FieryiGen5DCEliteG80T250DotMatteDryInkv1F { get; set; }
            public _﻿FieryIgen5Dceliteg80TCMYKB210DotMatteDryInkV1f _﻿FieryiGen5DCEliteG80TCMYKB210DotMatteDryInkv1F { get; set; }
            public _﻿FieryIgen5Dceliteg80TCMYKG180DotMatteDryInkV1f _﻿FieryiGen5DCEliteG80TCMYKG180DotMatteDryInkv1F { get; set; }
            public _﻿FieryIgen5Dceliteg80TCMYKO180DotMatteDryInkV1f _﻿FieryiGen5DCEliteG80TCMYKO180DotMatteDryInkv1F { get; set; }
            public _﻿AdobeRGB1998 _﻿AdobeRGB1998 { get; set; }
            public _﻿AppleStandard _﻿AppleStandard { get; set; }
            public _﻿EFIRGB _﻿EFIRGB { get; set; }
            public _﻿FieryRGBV5 _﻿FieryRGBv5 { get; set; }
            public _﻿EcirgbV2 _﻿eciRGBv2 { get; set; }
            public _﻿SrgbPC _﻿sRGBPC { get; set; }
            public CMYK CMYK { get; set; }
            public CMYKPLUS CMYKPLUS { get; set; }
            public Grayscale Grayscale { get; set; }
            public OFF OFF { get; set; }
            public ON ON { get; set; }
            public SEPOUT SEPOUT { get; set; }
            public SEPSIM SEPSIM { get; set; }
            public ABSOLUTE ABSOLUTE { get; set; }
            public PHOTOGRAPHIC PHOTOGRAPHIC { get; set; }
            public PRESENTATION PRESENTATION { get; set; }
            public RELATIVE RELATIVE { get; set; }
            public BLACKNORMAL BLACKNORMAL { get; set; }
            public BLACKPUREON BLACKPUREON { get; set; }
            public BLACKRICHPURE BLACKRICHPURE { get; set; }
            public TEXTGRAPHICS TEXTGRAPHICS { get; set; }
            public TEXTONLY TEXTONLY { get; set; }
            public TEXTGRAPHICSIMAG TEXTGRAPHICSIMAG { get; set; }
            public MATCHCOPY MATCHCOPY { get; set; }
            public SIMNONE SIMNONE { get; set; }
            public _﻿DICEFI _﻿DICEFI { get; set; }
            public _﻿Gracol2006Coated1EFI _﻿GRACoL2006Coated1EFI { get; set; }
            public _﻿Gracol2013CRPC6EFI _﻿GRACoL2013CRPC6EFI { get; set; }
            public _﻿ISOCoatedFOGRA39LEFI _﻿ISOCoatedFOGRA39LEFI { get; set; }
            public _﻿JapanColor2011Coated _﻿JapanColor2011Coated { get; set; }
            public _﻿PSOCoatedFOGRA51EFI _﻿PSOCoatedFOGRA51EFI { get; set; }
            public _﻿PSOUncoatedFOGRA52EFI _﻿PSOUncoatedFOGRA52EFI { get; set; }
            public _﻿SWOP2013CRPC5EFI _﻿SWOP2013CRPC5EFI { get; set; }
            public _﻿TOYOOffsetCoated20 _﻿TOYOOffsetCoated20 { get; set; }
            public XGAM XGAM { get; set; }
            public _﻿DotGain10 _﻿DotGain10 { get; set; }
            public _﻿DotGain15 _﻿DotGain15 { get; set; }
            public _﻿DotGain20 _﻿DotGain20 { get; set; }
            public _﻿DotGain25 _﻿DotGain25 { get; set; }
            public _﻿DotGain30 _﻿DotGain30 { get; set; }
            public _﻿GrayGamma18 _﻿GrayGamma18 { get; set; }
            public _﻿GrayGamma22 _﻿GrayGamma22 { get; set; }
            public Nocorrection NoCorrection { get; set; }
            public Default Default { get; set; }
            public BLANKKO_FALSE_HELP_WHITE BLANKKO_FALSE_HELP_WHITE { get; set; }
            public BLANKKO_TRUE_HELP_WHITE BLANKKO_TRUE_HELP_WHITE { get; set; }
            public CMYKAREA_HELP_WHITE CMYKAREA_HELP_WHITE { get; set; }
            public EFGRAPHIC_HELP_CLEAR EFGRAPHIC_HELP_CLEAR { get; set; }
            public EFIMAGE_HELP_CLEAR EFIMAGE_HELP_CLEAR { get; set; }
            public EFSPOTCOLOR_HELP_CLEAR EFSPOTCOLOR_HELP_CLEAR { get; set; }
            public EFTEXT_HELP_CLEAR EFTEXT_HELP_CLEAR { get; set; }
            public ENABLE_FALSE_HELP_CLEAR ENABLE_FALSE_HELP_CLEAR { get; set; }
            public ENABLE_FALSE_HELP_FALSE ENABLE_FALSE_HELP_FALSE { get; set; }
            public ENABLE_FALSE_HELP_WHITE ENABLE_FALSE_HELP_WHITE { get; set; }
            public ENABLE_TRUE_HELP_CLEAR ENABLE_TRUE_HELP_CLEAR { get; set; }
            public ENABLE_TRUE_HELP_FALSE ENABLE_TRUE_HELP_FALSE { get; set; }
            public ENABLE_TRUE_HELP_WHITE ENABLE_TRUE_HELP_WHITE { get; set; }
            public FULLPRINTAREA_HELP_CLEAR FULLPRINTAREA_HELP_CLEAR { get; set; }
            public FULLPRINTAREA_HELP_WHITE FULLPRINTAREA_HELP_WHITE { get; set; }
            public LIMITCOVERAGE_HELP_CLEAR LIMITCOVERAGE_HELP_CLEAR { get; set; }
            public NONWHITEAREA_HELP_CLEAR NONWHITEAREA_HELP_CLEAR { get; set; }
            public NONWHITEAREA_HELP_WHITE NONWHITEAREA_HELP_WHITE { get; set; }
            public NUMLAYERS_1_HELP_WHITE NUMLAYERS_1_HELP_WHITE { get; set; }
            public NUMLAYERS_2_HELP_WHITE NUMLAYERS_2_HELP_WHITE { get; set; }
            public ORDER_AFTERCMYK_HELP_WHITE ORDER_AFTERCMYK_HELP_WHITE { get; set; }
            public ORDER_BEFORECMYK_HELP_WHITE ORDER_BEFORECMYK_HELP_WHITE { get; set; }
            public ORDER_WITHOUTCMYK_HELP_WHITE ORDER_WITHOUTCMYK_HELP_WHITE { get; set; }
            public RANGETYPE_ALLPAGES_HELP_CLEAR RANGETYPE_ALLPAGES_HELP_CLEAR { get; set; }
            public RANGETYPE_ALLPAGES_HELP_WHITE RANGETYPE_ALLPAGES_HELP_WHITE { get; set; }
            public RANGETYPE_PAGES_HELP_CLEAR RANGETYPE_PAGES_HELP_CLEAR { get; set; }
            public RANGETYPE_PAGES_HELP_WHITE RANGETYPE_PAGES_HELP_WHITE { get; set; }
            public RANGETYPE_SHEETS_HELP_CLEAR RANGETYPE_SHEETS_HELP_CLEAR { get; set; }
            public RANGETYPE_SHEETS_HELP_WHITE RANGETYPE_SHEETS_HELP_WHITE { get; set; }
            public RIPOPTIONS_HELP_CLEAR RIPOPTIONS_HELP_CLEAR { get; set; }
            public RIPOPTIONS_HELP_FALSE RIPOPTIONS_HELP_FALSE { get; set; }
            public RIPOPTIONS_HELP_WHITE RIPOPTIONS_HELP_WHITE { get; set; }
            public WITHWHITEAREA_HELP_CLEAR WITHWHITEAREA_HELP_CLEAR { get; set; }
            public WITHWHITEAREA_HELP_WHITE WITHWHITEAREA_HELP_WHITE { get; set; }
            public Cmykarea_White CMYKArea_White { get; set; }
            public Enable_Clear Enable_Clear { get; set; }
            public Enable_False Enable_False { get; set; }
            public Enable_White Enable_White { get; set; }
            public Fullprintarea_Clear FullPrintArea_Clear { get; set; }
            public Fullprintarea_White FullPrintArea_White { get; set; }
            public Limitcoverage_Clear LimitCoverage_Clear { get; set; }
            public Nonwhitearea_Clear NonWhiteArea_Clear { get; set; }
            public Nonwhitearea_White NonWhiteArea_White { get; set; }
            public Withwhitearea_Clear WithWhiteArea_Clear { get; set; }
            public Withwhitearea_White WithWhiteArea_White { get; set; }
            public Cmykarea CMYKArea { get; set; }
            public Fullprintarea FullPrintArea { get; set; }
            public Nonwhitearea NonWhiteArea { get; set; }
            public Withwhitearea WithWhiteArea { get; set; }
            public Allpages AllPages { get; set; }
            public Pages Pages { get; set; }
            public Sheets Sheets { get; set; }
            public Aftercmyk AfterCMYK { get; set; }
            public Beforecmyk BeforeCMYK { get; set; }
            public Withoutcmyk WithoutCMYK { get; set; }
            public Bestquality BestQuality { get; set; }
            public Normalquality NormalQuality { get; set; }
            public Medium Medium { get; set; }
            public Screen1 Screen1 { get; set; }
            public Screen2 Screen2 { get; set; }
            public Screen3 Screen3 { get; set; }
            public Screen4 Screen4 { get; set; }
            public _0000 _0000 { get; set; }
            public Sameasimage SameAsImage { get; set; }
            public _2400X2400dpi _2400x2400dpi { get; set; }
            public _600X600dpi _600x600dpi { get; set; }
            public Appdef AppDef { get; set; }
            public Contone Contone { get; set; }
            public Newsprint Newsprint { get; set; }
            public Off1 Off { get; set; }
            public On1 On { get; set; }
            public Sort Sort { get; set; }
            public Reverseorderfacedown ReverseOrderFaceDown { get; set; }
            public Reverseorderfaceup ReverseOrderFaceUp { get; set; }
            public Sameorderfacedown SameOrderFaceDown { get; set; }
            public Sameorderfaceup SameOrderFaceUp { get; set; }
            public Finisher Finisher { get; set; }
            public Inches Inches { get; set; }
            public MM MM { get; set; }
            public Points Points { get; set; }
            public Numpages NumPages { get; set; }
            public Once Once { get; set; }
            public Alljobs AllJobs { get; set; }
            public Currentjob CurrentJob { get; set; }
            public Sheet Sheet { get; set; }
            public Sheetorset SheetOrSet { get; set; }
            public Nestedsaddleleft NestedSaddleLeft { get; set; }
            public Nestedsaddleright NestedSaddleRight { get; set; }
            public Nestedsaddletop NestedSaddleTop { get; set; }
            public Perfectleft PerfectLeft { get; set; }
            public Saddleleft SaddleLeft { get; set; }
            public Saddleright SaddleRight { get; set; }
            public Saddletop SaddleTop { get; set; }
            public Copies Copies { get; set; }
            public Sets Sets { get; set; }
            public Custom6 Custom { get; set; }
            public Sameasjob SameAsJob { get; set; }
            public Afterjob AfterJob { get; set; }
            public Profile1 Profile1 { get; set; }
            public Profile2 Profile2 { get; set; }
            public Profile3 Profile3 { get; set; }
            public Profile4 Profile4 { get; set; }
            public Formc1 formC1 { get; set; }
            public Formc10 formC10 { get; set; }
            public Formc100 formC100 { get; set; }
            public Formc11 formC11 { get; set; }
            public Formc12 formC12 { get; set; }
            public Formc13 formC13 { get; set; }
            public Formc14 formC14 { get; set; }
            public Formc15 formC15 { get; set; }
            public Formc16 formC16 { get; set; }
            public Formc17 formC17 { get; set; }
            public Formc18 formC18 { get; set; }
            public Formc19 formC19 { get; set; }
            public Formc2 formC2 { get; set; }
            public Formc20 formC20 { get; set; }
            public Formc21 formC21 { get; set; }
            public Formc22 formC22 { get; set; }
            public Formc23 formC23 { get; set; }
            public Formc24 formC24 { get; set; }
            public Formc25 formC25 { get; set; }
            public Formc26 formC26 { get; set; }
            public Formc27 formC27 { get; set; }
            public Formc28 formC28 { get; set; }
            public Formc29 formC29 { get; set; }
            public Formc3 formC3 { get; set; }
            public Formc30 formC30 { get; set; }
            public Formc31 formC31 { get; set; }
            public Formc32 formC32 { get; set; }
            public Formc33 formC33 { get; set; }
            public Formc34 formC34 { get; set; }
            public Formc35 formC35 { get; set; }
            public Formc36 formC36 { get; set; }
            public Formc37 formC37 { get; set; }
            public Formc38 formC38 { get; set; }
            public Formc39 formC39 { get; set; }
            public Formc4 formC4 { get; set; }
            public Formc40 formC40 { get; set; }
            public Formc41 formC41 { get; set; }
            public Formc42 formC42 { get; set; }
            public Formc43 formC43 { get; set; }
            public Formc44 formC44 { get; set; }
            public Formc45 formC45 { get; set; }
            public Formc46 formC46 { get; set; }
            public Formc47 formC47 { get; set; }
            public Formc48 formC48 { get; set; }
            public Formc49 formC49 { get; set; }
            public Formc5 formC5 { get; set; }
            public Formc50 formC50 { get; set; }
            public Formc51 formC51 { get; set; }
            public Formc52 formC52 { get; set; }
            public Formc53 formC53 { get; set; }
            public Formc54 formC54 { get; set; }
            public Formc55 formC55 { get; set; }
            public Formc56 formC56 { get; set; }
            public Formc57 formC57 { get; set; }
            public Formc58 formC58 { get; set; }
            public Formc59 formC59 { get; set; }
            public Formc6 formC6 { get; set; }
            public Formc60 formC60 { get; set; }
            public Formc61 formC61 { get; set; }
            public Formc62 formC62 { get; set; }
            public Formc63 formC63 { get; set; }
            public Formc64 formC64 { get; set; }
            public Formc65 formC65 { get; set; }
            public Formc66 formC66 { get; set; }
            public Formc67 formC67 { get; set; }
            public Formc68 formC68 { get; set; }
            public Formc69 formC69 { get; set; }
            public Formc7 formC7 { get; set; }
            public Formc70 formC70 { get; set; }
            public Formc71 formC71 { get; set; }
            public Formc72 formC72 { get; set; }
            public Formc73 formC73 { get; set; }
            public Formc74 formC74 { get; set; }
            public Formc75 formC75 { get; set; }
            public Formc76 formC76 { get; set; }
            public Formc77 formC77 { get; set; }
            public Formc78 formC78 { get; set; }
            public Formc79 formC79 { get; set; }
            public Formc8 formC8 { get; set; }
            public Formc80 formC80 { get; set; }
            public Formc81 formC81 { get; set; }
            public Formc82 formC82 { get; set; }
            public Formc83 formC83 { get; set; }
            public Formc84 formC84 { get; set; }
            public Formc85 formC85 { get; set; }
            public Formc86 formC86 { get; set; }
            public Formc87 formC87 { get; set; }
            public Formc88 formC88 { get; set; }
            public Formc89 formC89 { get; set; }
            public Formc9 formC9 { get; set; }
            public Formc90 formC90 { get; set; }
            public Formc91 formC91 { get; set; }
            public Formc92 formC92 { get; set; }
            public Formc93 formC93 { get; set; }
            public Formc94 formC94 { get; set; }
            public Formc95 formC95 { get; set; }
            public Formc96 formC96 { get; set; }
            public Formc97 formC97 { get; set; }
            public Formc98 formC98 { get; set; }
            public Formc99 formC99 { get; set; }
            public Formu1 formU1 { get; set; }
            public Formu10 formU10 { get; set; }
            public Formu100 formU100 { get; set; }
            public Formu11 formU11 { get; set; }
            public Formu12 formU12 { get; set; }
            public Formu13 formU13 { get; set; }
            public Formu14 formU14 { get; set; }
            public Formu15 formU15 { get; set; }
            public Formu16 formU16 { get; set; }
            public Formu17 formU17 { get; set; }
            public Formu18 formU18 { get; set; }
            public Formu19 formU19 { get; set; }
            public Formu2 formU2 { get; set; }
            public Formu20 formU20 { get; set; }
            public Formu21 formU21 { get; set; }
            public Formu22 formU22 { get; set; }
            public Formu23 formU23 { get; set; }
            public Formu24 formU24 { get; set; }
            public Formu25 formU25 { get; set; }
            public Formu26 formU26 { get; set; }
            public Formu27 formU27 { get; set; }
            public Formu28 formU28 { get; set; }
            public Formu29 formU29 { get; set; }
            public Formu3 formU3 { get; set; }
            public Formu30 formU30 { get; set; }
            public Formu31 formU31 { get; set; }
            public Formu32 formU32 { get; set; }
            public Formu33 formU33 { get; set; }
            public Formu34 formU34 { get; set; }
            public Formu35 formU35 { get; set; }
            public Formu36 formU36 { get; set; }
            public Formu37 formU37 { get; set; }
            public Formu38 formU38 { get; set; }
            public Formu39 formU39 { get; set; }
            public Formu4 formU4 { get; set; }
            public Formu40 formU40 { get; set; }
            public Formu41 formU41 { get; set; }
            public Formu42 formU42 { get; set; }
            public Formu43 formU43 { get; set; }
            public Formu44 formU44 { get; set; }
            public Formu45 formU45 { get; set; }
            public Formu46 formU46 { get; set; }
            public Formu47 formU47 { get; set; }
            public Formu48 formU48 { get; set; }
            public Formu49 formU49 { get; set; }
            public Formu5 formU5 { get; set; }
            public Formu50 formU50 { get; set; }
            public Formu51 formU51 { get; set; }
            public Formu52 formU52 { get; set; }
            public Formu53 formU53 { get; set; }
            public Formu54 formU54 { get; set; }
            public Formu55 formU55 { get; set; }
            public Formu56 formU56 { get; set; }
            public Formu57 formU57 { get; set; }
            public Formu58 formU58 { get; set; }
            public Formu59 formU59 { get; set; }
            public Formu6 formU6 { get; set; }
            public Formu60 formU60 { get; set; }
            public Formu61 formU61 { get; set; }
            public Formu62 formU62 { get; set; }
            public Formu63 formU63 { get; set; }
            public Formu64 formU64 { get; set; }
            public Formu65 formU65 { get; set; }
            public Formu66 formU66 { get; set; }
            public Formu67 formU67 { get; set; }
            public Formu68 formU68 { get; set; }
            public Formu69 formU69 { get; set; }
            public Formu7 formU7 { get; set; }
            public Formu70 formU70 { get; set; }
            public Formu71 formU71 { get; set; }
            public Formu72 formU72 { get; set; }
            public Formu73 formU73 { get; set; }
            public Formu74 formU74 { get; set; }
            public Formu75 formU75 { get; set; }
            public Formu76 formU76 { get; set; }
            public Formu77 formU77 { get; set; }
            public Formu78 formU78 { get; set; }
            public Formu79 formU79 { get; set; }
            public Formu8 formU8 { get; set; }
            public Formu80 formU80 { get; set; }
            public Formu81 formU81 { get; set; }
            public Formu82 formU82 { get; set; }
            public Formu83 formU83 { get; set; }
            public Formu84 formU84 { get; set; }
            public Formu85 formU85 { get; set; }
            public Formu86 formU86 { get; set; }
            public Formu87 formU87 { get; set; }
            public Formu88 formU88 { get; set; }
            public Formu89 formU89 { get; set; }
            public Formu9 formU9 { get; set; }
            public Formu90 formU90 { get; set; }
            public Formu91 formU91 { get; set; }
            public Formu92 formU92 { get; set; }
            public Formu93 formU93 { get; set; }
            public Formu94 formU94 { get; set; }
            public Formu95 formU95 { get; set; }
            public Formu96 formU96 { get; set; }
            public Formu97 formU97 { get; set; }
            public Formu98 formU98 { get; set; }
            public Formu99 formU99 { get; set; }
            public Fiery_Default fiery_default { get; set; }
            public Graphic_Arts graphic_arts { get; set; }
            public Performance performance { get; set; }
            public Production production { get; set; }
            public Dot Dot { get; set; }
            public Ellipse Ellipse { get; set; }
            public Line Line { get; set; }
            public Null Null { get; set; }
            public NullInverse NullInverse { get; set; }
            public Customcolor85Lpi600Dpi CustomColor85lpi600dpi { get; set; }
            public Processblack85Lpi600Dpi ProcessBlack85lpi600dpi { get; set; }
            public Processcyan85Lpi600Dpi ProcessCyan85lpi600dpi { get; set; }
            public Processmagenta85Lpi600Dpi ProcessMagenta85lpi600dpi { get; set; }
            public Processyellow85Lpi600Dpi ProcessYellow85lpi600dpi { get; set; }
            public P199fieryred P199FieryRed { get; set; }
            public P300fieryblue P300FieryBlue { get; set; }
            public Pblackfieryblack PblackFieryBlack { get; set; }
        }

        public class _00
        {
            public string MainKeyword { get; set; }
            public string section { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _120
        {
            public string MainKeyword { get; set; }
            public string section { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _200
        {
            public string MainKeyword { get; set; }
            public string section { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _210
        {
            public string MainKeyword { get; set; }
            public string section { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _250
        {
            public string MainKeyword { get; set; }
            public string section { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _350
        {
            public string MainKeyword { get; set; }
            public string section { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _400
        {
            public string MainKeyword { get; set; }
            public string section { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _490
        {
            public string MainKeyword { get; set; }
            public string section { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _50
        {
            public string MainKeyword { get; set; }
            public string section { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _500
        {
            public string MainKeyword { get; set; }
            public string section { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _520
        {
            public string MainKeyword { get; set; }
            public string section { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _540
        {
            public string MainKeyword { get; set; }
            public string section { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _550
        {
            public string MainKeyword { get; set; }
            public string section { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _560
        {
            public string MainKeyword { get; set; }
            public string section { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _565
        {
            public string MainKeyword { get; set; }
            public string section { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _570
        {
            public string MainKeyword { get; set; }
            public string section { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _580
        {
            public string MainKeyword { get; set; }
            public string section { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _584
        {
            public string MainKeyword { get; set; }
            public string section { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _585
        {
            public string MainKeyword { get; set; }
            public string section { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _586
        {
            public string MainKeyword { get; set; }
            public string section { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _590
        {
            public string MainKeyword { get; set; }
            public string section { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _600
        {
            public string MainKeyword { get; set; }
            public string section { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _610
        {
            public string MainKeyword { get; set; }
            public string section { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _611
        {
            public string MainKeyword { get; set; }
            public string section { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _620
        {
            public string MainKeyword { get; set; }
            public string section { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _650
        {
            public string MainKeyword { get; set; }
            public string section { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _700
        {
            public string MainKeyword { get; set; }
            public string section { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _900
        {
            public string MainKeyword { get; set; }
            public string section { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _950
        {
            public string MainKeyword { get; set; }
            public string section { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class False
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class True
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class GA2
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Stacker1
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Stacker2
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Stacker3
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Stacker4
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Toptray1
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Toptray2
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Toptray3
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Toptray4
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Blue
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Clear
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Green
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Orange
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class White
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Feeder1
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Feeder2
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Feeder3
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Feeder4
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Feeder5
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Feeder6
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Inserter1
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Inserter2
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Invocation
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class All
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Even
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Odd
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Range1
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class NO
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class YES
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Child
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Usefilename
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Usepstitle
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Hold
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Printndelete
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Ripnhold
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Colorcodedjob
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Reportconcise
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Testpage
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Plain
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Preprinted
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Tabpaper1
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Tabpaper2
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Tabstock
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Transparency
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Userdefined
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_101103
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_104106
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_107109
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_110112
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_113115
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_116118
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_119121
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_122124
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_125127
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_128130
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_131133
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_134136
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_137139
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_140142
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_143145
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_146148
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_149151
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_152154
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_155157
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_158160
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_161163
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_164166
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_167169
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_170172
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_173175
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_176178
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_179181
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_180530
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_182184
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_185187
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_188190
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_191193
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_194196
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_197199
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_200202
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_203205
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_206208
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_209211
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_212214
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_215217
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_218220
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_221223
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_224226
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_227229
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_230232
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_233235
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_236238
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_239241
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_242244
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_245247
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_248250
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_251253
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_254256
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_257259
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_260262
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_263265
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_266268
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_269271
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_272274
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_275277
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_278280
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_281283
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_284286
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_287289
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_290292
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_293295
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_296298
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_299301
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_302304
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_305307
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_308310
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_311313
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_314316
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_317319
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_320322
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_323325
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_326328
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_329331
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_332334
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_335337
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_338340
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_341343
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_344346
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_347349
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_350
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_6061
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_6264
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_6567
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_6870
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_7173
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_7476
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_7779
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_8082
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_8385
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_8688
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_8991
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_9294
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_9597
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gsm_98100
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Buff
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Custom1
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Custom2
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Custom3
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Custom4
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Custom5
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Goldenrod
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Gray
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Ivory
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Pink
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Red
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Yellow
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Regular
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Rough
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Semirough
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Smooth
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Both
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class None
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Side1
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Glossy
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Highgloss
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Matte
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Satin
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Semigloss
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _1
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _12X26
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _1433X26
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _143X205
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _143X225
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _9X11
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _9X11r
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class A3
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class A4
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class A4oversizedtab
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class A4oversizedtabr
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class A4R
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class B4
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class B4R
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Customprintsize
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Fanfoldgermanlegal
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Fanfoldgermanlegalr
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class ISOB3
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class ISOB4
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class ISOB4R
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Legal
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Legalr
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Letter
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Letterr
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class SRA3
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Sameaspagesize
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Tabloid
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Tabloidextra
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Custom
        {
            public float BottomHWMargin { get; set; }
            public float LeftHWMargin { get; set; }
            public float RightHWMargin { get; set; }
            public float TopHWMargin { get; set; }
            public object[] uneditablekeys { get; set; }
            public int MaxMediaHeight { get; set; }
            public int MaxMediaWidth { get; set; }
            public string command { get; set; }
        }

        public class Metric
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class US
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Autoselect
        {
            public string InputSlotProperties { get; set; }
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Postfusertray
        {
            public string InputSlotProperties { get; set; }
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Postfusertray2
        {
            public string InputSlotProperties { get; set; }
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Postfusertray3
        {
            public string InputSlotProperties { get; set; }
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Postfusertray4
        {
            public string InputSlotProperties { get; set; }
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Tray1
        {
            public string InputSlotProperties { get; set; }
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Tray10
        {
            public string InputSlotProperties { get; set; }
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Tray11
        {
            public string InputSlotProperties { get; set; }
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Tray12
        {
            public string InputSlotProperties { get; set; }
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Tray2
        {
            public string InputSlotProperties { get; set; }
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Tray3
        {
            public string InputSlotProperties { get; set; }
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Tray4
        {
            public string InputSlotProperties { get; set; }
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Tray5
        {
            public string InputSlotProperties { get; set; }
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Tray6
        {
            public string InputSlotProperties { get; set; }
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Tray7
        {
            public string InputSlotProperties { get; set; }
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Tray8
        {
            public string InputSlotProperties { get; set; }
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Tray9
        {
            public string InputSlotProperties { get; set; }
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Blank
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Tab
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Printback
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Printboth
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Printfront
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Bypass
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Documentdef
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Stacker
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Stackerauto
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Top
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Top2
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Top3
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Top4
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Toptrayauto
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Firsttolast
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Lasttofirst
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Topbottom
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Toptop
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class A4toletter
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Lettertoa4
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Landscape
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Portrait
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _16ULH
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _16ULV
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _16URH
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _16URV
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _1UP
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _2ULH
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _2ULV
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _2URH
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _2URV
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _4ULH
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _4ULV
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _4URH
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _4URV
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _6ULH
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _6ULV
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _6URH
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _6URV
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _9ULH
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _9ULV
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _9URH
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _9URV
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Double
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Nestsaddlel
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Nestsaddler
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Nestsaddlet
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Perfect
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Perfectright
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Perfecttop
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Speed
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Twoup
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Twoupright
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Twouptop
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Side2
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Multipagenospine
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Preprinted1
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Thick
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Useimageable
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _10
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _11
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _12
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _13
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _14
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _15
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _16
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _17
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _18
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _19
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _2
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _20
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _3
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _4
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _5
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _6
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _7
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _8
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _9
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Bottom
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Middle
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Auto
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Left
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Right
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _2Up_Landscape
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Duplex_Grayscale
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Large_Booklet
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Small_Booklet
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Usesystemdefault
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class DEFAULT_MEDIA
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _﻿FieryIgen5Dceliteg80T160DotMatteDryInkV1f
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _﻿FieryIgen5Dceliteg80T180DotMatteDryInkV1f
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _﻿FieryIgen5Dceliteg80T210DotMatteDryInkV1f
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _﻿FieryIgen5Dceliteg80T250DotMatteDryInkV1f
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _﻿FieryIgen5Dceliteg80TCMYKB210DotMatteDryInkV1f
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _﻿FieryIgen5Dceliteg80TCMYKG180DotMatteDryInkV1f
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _﻿FieryIgen5Dceliteg80TCMYKO180DotMatteDryInkV1f
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _﻿AdobeRGB1998
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _﻿AppleStandard
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _﻿EFIRGB
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _﻿FieryRGBV5
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _﻿EcirgbV2
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _﻿SrgbPC
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class CMYK
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class CMYKPLUS
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Grayscale
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class OFF
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class ON
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class SEPOUT
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class SEPSIM
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class ABSOLUTE
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class PHOTOGRAPHIC
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class PRESENTATION
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class RELATIVE
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class BLACKNORMAL
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class BLACKPUREON
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class BLACKRICHPURE
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class TEXTGRAPHICS
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class TEXTONLY
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class TEXTGRAPHICSIMAG
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class MATCHCOPY
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class SIMNONE
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _﻿DICEFI
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _﻿Gracol2006Coated1EFI
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _﻿Gracol2013CRPC6EFI
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _﻿ISOCoatedFOGRA39LEFI
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _﻿JapanColor2011Coated
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _﻿PSOCoatedFOGRA51EFI
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _﻿PSOUncoatedFOGRA52EFI
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _﻿SWOP2013CRPC5EFI
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _﻿TOYOOffsetCoated20
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class XGAM
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _﻿DotGain10
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _﻿DotGain15
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _﻿DotGain20
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _﻿DotGain25
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _﻿DotGain30
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _﻿GrayGamma18
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _﻿GrayGamma22
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Nocorrection
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Default
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class BLANKKO_FALSE_HELP_WHITE
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class BLANKKO_TRUE_HELP_WHITE
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class CMYKAREA_HELP_WHITE
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class EFGRAPHIC_HELP_CLEAR
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class EFIMAGE_HELP_CLEAR
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class EFSPOTCOLOR_HELP_CLEAR
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class EFTEXT_HELP_CLEAR
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class ENABLE_FALSE_HELP_CLEAR
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class ENABLE_FALSE_HELP_FALSE
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class ENABLE_FALSE_HELP_WHITE
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class ENABLE_TRUE_HELP_CLEAR
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class ENABLE_TRUE_HELP_FALSE
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class ENABLE_TRUE_HELP_WHITE
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class FULLPRINTAREA_HELP_CLEAR
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class FULLPRINTAREA_HELP_WHITE
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class LIMITCOVERAGE_HELP_CLEAR
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class NONWHITEAREA_HELP_CLEAR
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class NONWHITEAREA_HELP_WHITE
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class NUMLAYERS_1_HELP_WHITE
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class NUMLAYERS_2_HELP_WHITE
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class ORDER_AFTERCMYK_HELP_WHITE
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class ORDER_BEFORECMYK_HELP_WHITE
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class ORDER_WITHOUTCMYK_HELP_WHITE
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class RANGETYPE_ALLPAGES_HELP_CLEAR
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class RANGETYPE_ALLPAGES_HELP_WHITE
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class RANGETYPE_PAGES_HELP_CLEAR
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class RANGETYPE_PAGES_HELP_WHITE
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class RANGETYPE_SHEETS_HELP_CLEAR
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class RANGETYPE_SHEETS_HELP_WHITE
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class RIPOPTIONS_HELP_CLEAR
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class RIPOPTIONS_HELP_FALSE
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class RIPOPTIONS_HELP_WHITE
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class WITHWHITEAREA_HELP_CLEAR
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class WITHWHITEAREA_HELP_WHITE
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Cmykarea_White
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Enable_Clear
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Enable_False
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Enable_White
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Fullprintarea_Clear
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Fullprintarea_White
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Limitcoverage_Clear
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Nonwhitearea_Clear
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Nonwhitearea_White
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Withwhitearea_Clear
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Withwhitearea_White
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Cmykarea
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Fullprintarea
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Nonwhitearea
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Withwhitearea
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Allpages
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Pages
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Sheets
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Aftercmyk
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Beforecmyk
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Withoutcmyk
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Bestquality
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Normalquality
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Medium
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Screen1
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Screen2
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Screen3
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Screen4
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _008
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _016
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _024
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _0000
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Sameasimage
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _2400X2400dpi
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class _600X600dpi
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Appdef
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Contone
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Newsprint
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Off1
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class On1
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Sort
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Reverseorderfacedown
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Reverseorderfaceup
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Sameorderfacedown
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Sameorderfaceup
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Finisher
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Inches
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class MM
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Points
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Numpages
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Once
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Alljobs
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Currentjob
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Sheet
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Sheetorset
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Nestedsaddleleft
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Nestedsaddleright
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Nestedsaddletop
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Perfectleft
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Saddleleft
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Saddleright
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Saddletop
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Copies
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Sets
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Custom6
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Sameasjob
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Afterjob
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Profile1
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Profile2
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Profile3
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Profile4
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc1
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc10
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc100
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc11
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc12
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc13
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc14
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc15
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc16
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc17
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc18
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc19
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc2
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc20
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc21
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc22
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc23
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc24
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc25
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc26
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc27
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc28
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc29
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc3
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc30
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc31
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc32
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc33
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc34
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc35
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc36
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc37
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc38
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc39
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc4
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc40
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc41
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc42
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc43
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc44
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc45
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc46
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc47
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc48
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc49
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc5
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc50
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc51
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc52
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc53
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc54
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc55
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc56
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc57
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc58
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc59
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc6
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc60
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc61
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc62
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc63
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc64
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc65
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc66
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc67
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc68
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc69
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc7
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc70
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc71
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc72
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc73
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc74
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc75
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc76
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc77
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc78
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc79
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc8
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc80
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc81
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc82
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc83
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc84
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc85
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc86
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc87
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc88
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc89
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc9
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc90
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc91
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc92
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc93
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc94
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc95
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc96
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc97
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc98
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formc99
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu1
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu10
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu100
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu11
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu12
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu13
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu14
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu15
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu16
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu17
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu18
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu19
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu2
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu20
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu21
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu22
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu23
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu24
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu25
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu26
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu27
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu28
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu29
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu3
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu30
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu31
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu32
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu33
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu34
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu35
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu36
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu37
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu38
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu39
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu4
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu40
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu41
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu42
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu43
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu44
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu45
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu46
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu47
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu48
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu49
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu5
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu50
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu51
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu52
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu53
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu54
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu55
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu56
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu57
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu58
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu59
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu6
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu60
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu61
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu62
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu63
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu64
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu65
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu66
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu67
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu68
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu69
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu7
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu70
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu71
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu72
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu73
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu74
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu75
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu76
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu77
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu78
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu79
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu8
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu80
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu81
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu82
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu83
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu84
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu85
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu86
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu87
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu88
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu89
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu9
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu90
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu91
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu92
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu93
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu94
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu95
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu96
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu97
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu98
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Formu99
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Fiery_Default
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Graphic_Arts
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Performance
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Production
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Dot
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Ellipse
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Line
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Null
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class NullInverse
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Customcolor85Lpi600Dpi
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Processblack85Lpi600Dpi
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Processcyan85Lpi600Dpi
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Processmagenta85Lpi600Dpi
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Processyellow85Lpi600Dpi
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class P199fieryred
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class P300fieryblue
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Pblackfieryblack
        {
            public string command { get; set; }
            public object[] uneditablekeys { get; set; }
        }

        public class Constraints
        {
            public False1 False { get; set; }
            public True1 True { get; set; }
            public object GA2 { get; set; }
            public Stacker11 Stacker1 { get; set; }
            public Stacker21 Stacker2 { get; set; }
            public Stacker31 Stacker3 { get; set; }
            public Stacker41 Stacker4 { get; set; }
            public Toptray11 TopTray1 { get; set; }
            public Toptray21 TopTray2 { get; set; }
            public Toptray31 TopTray3 { get; set; }
            public object TopTray4 { get; set; }
            public All1 All { get; set; }
            public Even1 Even { get; set; }
            public Odd1 Odd { get; set; }
            public Range11 Range1 { get; set; }
            public object Fiery { get; set; }
            public Colorcodedjob1 ColorCodedJob { get; set; }
            public Reportconcise1 ReportConcise { get; set; }
            public Testpage1 TestPage { get; set; }
            public Plain1 Plain { get; set; }
            public Preprinted2 Preprinted { get; set; }
            public Tabpaper11 Tabpaper1 { get; set; }
            public Tabpaper21 Tabpaper2 { get; set; }
            public Tabstock1 Tabstock { get; set; }
            public Transparency1 Transparency { get; set; }
            public object UserDefined { get; set; }
            public object gsm_101103 { get; set; }
            public object gsm_104106 { get; set; }
            public object gsm_107109 { get; set; }
            public object gsm_110112 { get; set; }
            public object gsm_113115 { get; set; }
            public object gsm_116118 { get; set; }
            public object gsm_119121 { get; set; }
            public object gsm_122124 { get; set; }
            public object gsm_125127 { get; set; }
            public object gsm_128130 { get; set; }
            public object gsm_131133 { get; set; }
            public object gsm_134136 { get; set; }
            public object gsm_137139 { get; set; }
            public object gsm_140142 { get; set; }
            public object gsm_143145 { get; set; }
            public object gsm_146148 { get; set; }
            public object gsm_149151 { get; set; }
            public object gsm_152154 { get; set; }
            public object gsm_155157 { get; set; }
            public object gsm_158160 { get; set; }
            public object gsm_161163 { get; set; }
            public object gsm_164166 { get; set; }
            public object gsm_167169 { get; set; }
            public object gsm_170172 { get; set; }
            public object gsm_173175 { get; set; }
            public object gsm_176178 { get; set; }
            public object gsm_179181 { get; set; }
            public Gsm_1805301 gsm_180530 { get; set; }
            public object gsm_182184 { get; set; }
            public object gsm_185187 { get; set; }
            public object gsm_188190 { get; set; }
            public object gsm_191193 { get; set; }
            public object gsm_194196 { get; set; }
            public object gsm_197199 { get; set; }
            public object gsm_200202 { get; set; }
            public object gsm_203205 { get; set; }
            public object gsm_206208 { get; set; }
            public object gsm_209211 { get; set; }
            public object gsm_212214 { get; set; }
            public object gsm_215217 { get; set; }
            public object gsm_218220 { get; set; }
            public object gsm_221223 { get; set; }
            public object gsm_224226 { get; set; }
            public object gsm_227229 { get; set; }
            public object gsm_230232 { get; set; }
            public object gsm_233235 { get; set; }
            public object gsm_236238 { get; set; }
            public object gsm_239241 { get; set; }
            public object gsm_242244 { get; set; }
            public object gsm_245247 { get; set; }
            public object gsm_248250 { get; set; }
            public object gsm_251253 { get; set; }
            public object gsm_254256 { get; set; }
            public object gsm_257259 { get; set; }
            public object gsm_260262 { get; set; }
            public object gsm_263265 { get; set; }
            public object gsm_266268 { get; set; }
            public object gsm_269271 { get; set; }
            public object gsm_272274 { get; set; }
            public object gsm_275277 { get; set; }
            public object gsm_278280 { get; set; }
            public object gsm_281283 { get; set; }
            public object gsm_284286 { get; set; }
            public object gsm_287289 { get; set; }
            public object gsm_290292 { get; set; }
            public object gsm_293295 { get; set; }
            public object gsm_296298 { get; set; }
            public object gsm_299301 { get; set; }
            public object gsm_302304 { get; set; }
            public object gsm_305307 { get; set; }
            public object gsm_308310 { get; set; }
            public object gsm_311313 { get; set; }
            public object gsm_314316 { get; set; }
            public object gsm_317319 { get; set; }
            public object gsm_320322 { get; set; }
            public object gsm_323325 { get; set; }
            public object gsm_326328 { get; set; }
            public object gsm_329331 { get; set; }
            public object gsm_332334 { get; set; }
            public object gsm_335337 { get; set; }
            public object gsm_338340 { get; set; }
            public object gsm_341343 { get; set; }
            public object gsm_344346 { get; set; }
            public object gsm_347349 { get; set; }
            public object gsm_350 { get; set; }
            public object gsm_6061 { get; set; }
            public object gsm_6264 { get; set; }
            public object gsm_6567 { get; set; }
            public object gsm_6870 { get; set; }
            public object gsm_7173 { get; set; }
            public object gsm_7476 { get; set; }
            public object gsm_7779 { get; set; }
            public object gsm_8082 { get; set; }
            public object gsm_8385 { get; set; }
            public object gsm_8688 { get; set; }
            public object gsm_8991 { get; set; }
            public object gsm_9294 { get; set; }
            public object gsm_9597 { get; set; }
            public object gsm_98100 { get; set; }
            public object Blue { get; set; }
            public object Buff { get; set; }
            public Clear1 Clear { get; set; }
            public object Custom1 { get; set; }
            public object Custom2 { get; set; }
            public object Custom3 { get; set; }
            public object Custom4 { get; set; }
            public object Custom5 { get; set; }
            public object Goldenrod { get; set; }
            public object Gray { get; set; }
            public object Green { get; set; }
            public object Ivory { get; set; }
            public object Orange { get; set; }
            public object Pink { get; set; }
            public object Red { get; set; }
            public object White { get; set; }
            public object Yellow { get; set; }
            public Blank1 Blank { get; set; }
            public None1 None { get; set; }
            public Tab1 Tab { get; set; }
            public Printback1 PrintBack { get; set; }
            public Printboth1 PrintBoth { get; set; }
            public object PrintFront { get; set; }
            public Bypass1 Bypass { get; set; }
            public object DocumentDEF { get; set; }
            public Stacker5 Stacker { get; set; }
            public Stackerauto1 StackerAuto { get; set; }
            public Top1 Top { get; set; }
            public Top21 Top2 { get; set; }
            public Top31 Top3 { get; set; }
            public Top41 Top4 { get; set; }
            public Toptrayauto1 TopTrayAuto { get; set; }
            public Topbottom1 TopBottom { get; set; }
            public Toptop1 TopTop { get; set; }
            public _16ULH1 _16ULH { get; set; }
            public _16ULV1 _16ULV { get; set; }
            public _16URH1 _16URH { get; set; }
            public _16URV1 _16URV { get; set; }
            public _1UP1 _1UP { get; set; }
            public _2ULH1 _2ULH { get; set; }
            public _2ULV1 _2ULV { get; set; }
            public _2URH1 _2URH { get; set; }
            public _2URV1 _2URV { get; set; }
            public _4ULH1 _4ULH { get; set; }
            public _4ULV1 _4ULV { get; set; }
            public _4URH1 _4URH { get; set; }
            public _4URV1 _4URV { get; set; }
            public _6ULH1 _6ULH { get; set; }
            public _6ULV1 _6ULV { get; set; }
            public _6URH1 _6URH { get; set; }
            public _6URV1 _6URV { get; set; }
            public _9ULH1 _9ULH { get; set; }
            public _9ULV1 _9ULV { get; set; }
            public _9URH1 _9URH { get; set; }
            public _9URV1 _9URV { get; set; }
            public Double1 Double { get; set; }
            public Nestsaddlel1 NestSaddleL { get; set; }
            public Nestsaddler1 NestSaddleR { get; set; }
            public Nestsaddlet1 NestSaddleT { get; set; }
            public Perfect1 Perfect { get; set; }
            public Perfectright1 PerfectRight { get; set; }
            public Perfecttop1 PerfectTop { get; set; }
            public Speed1 Speed { get; set; }
            public Twoup1 TwoUp { get; set; }
            public Twoupright1 TwoUpRight { get; set; }
            public Twouptop1 TwoUpTop { get; set; }
            public object CMYK { get; set; }
            public CMYKPLUS1 CMYKPLUS { get; set; }
            public Grayscale1 Grayscale { get; set; }
            public object SEPOUT { get; set; }
            public SEPSIM1 SEPSIM { get; set; }
            public BLACKNORMAL1 BLACKNORMAL { get; set; }
            public object BLACKPUREON { get; set; }
            public object BLACKRICHPURE { get; set; }
            public OFF2 OFF { get; set; }
            public TEXTGRAPHICS1 TEXTGRAPHICS { get; set; }
            public TEXTONLY1 TEXTONLY { get; set; }
            public TEXTGRAPHICSIMAG1 TEXTGRAPHICSIMAG { get; set; }
            public MATCHCOPY1 MATCHCOPY { get; set; }
            public object SIMNONE { get; set; }
            public object _﻿DICEFI { get; set; }
            public object _﻿GRACoL2006Coated1EFI { get; set; }
            public object _﻿GRACoL2013CRPC6EFI { get; set; }
            public object _﻿ISOCoatedFOGRA39LEFI { get; set; }
            public object _﻿JapanColor2011Coated { get; set; }
            public object _﻿PSOCoatedFOGRA51EFI { get; set; }
            public object _﻿PSOUncoatedFOGRA52EFI { get; set; }
            public object _﻿SWOP2013CRPC5EFI { get; set; }
            public object _﻿TOYOOffsetCoated20 { get; set; }
            public Nocorrection1 NoCorrection { get; set; }
            public object ON { get; set; }
            public Cmykarea1 CMYKArea { get; set; }
            public object FullPrintArea { get; set; }
            public object NonWhiteArea { get; set; }
            public object WithWhiteArea { get; set; }
            public object _1 { get; set; }
            public _21 _2 { get; set; }
            public Screen11 Screen1 { get; set; }
            public Screen21 Screen2 { get; set; }
            public Screen31 Screen3 { get; set; }
            public object Screen4 { get; set; }
            public object SameAsImage { get; set; }
            public Appdef1 AppDef { get; set; }
            public object Contone { get; set; }
            public Newsprint1 Newsprint { get; set; }
            public Reverseorderfacedown1 ReverseOrderFaceDown { get; set; }
            public Reverseorderfaceup1 ReverseOrderFaceUp { get; set; }
            public object SameOrderFaceDown { get; set; }
            public Sameorderfaceup1 SameOrderFaceUp { get; set; }
            public Finisher1 Finisher { get; set; }
            public Profile11 Profile1 { get; set; }
            public Profile21 Profile2 { get; set; }
            public Profile31 Profile3 { get; set; }
            public Profile41 Profile4 { get; set; }
            public Formc110 formC1 { get; set; }
            public Formc101 formC10 { get; set; }
            public Formc1001 formC100 { get; set; }
            public Formc111 formC11 { get; set; }
            public Formc121 formC12 { get; set; }
            public Formc131 formC13 { get; set; }
            public Formc141 formC14 { get; set; }
            public Formc151 formC15 { get; set; }
            public Formc161 formC16 { get; set; }
            public Formc171 formC17 { get; set; }
            public Formc181 formC18 { get; set; }
            public Formc191 formC19 { get; set; }
            public Formc210 formC2 { get; set; }
            public Formc201 formC20 { get; set; }
            public Formc211 formC21 { get; set; }
            public Formc221 formC22 { get; set; }
            public Formc231 formC23 { get; set; }
            public Formc241 formC24 { get; set; }
            public Formc251 formC25 { get; set; }
            public Formc261 formC26 { get; set; }
            public Formc271 formC27 { get; set; }
            public Formc281 formC28 { get; set; }
            public Formc291 formC29 { get; set; }
            public Formc310 formC3 { get; set; }
            public Formc301 formC30 { get; set; }
            public Formc311 formC31 { get; set; }
            public Formc321 formC32 { get; set; }
            public Formc331 formC33 { get; set; }
            public Formc341 formC34 { get; set; }
            public Formc351 formC35 { get; set; }
            public Formc361 formC36 { get; set; }
            public Formc371 formC37 { get; set; }
            public Formc381 formC38 { get; set; }
            public Formc391 formC39 { get; set; }
            public Formc410 formC4 { get; set; }
            public Formc401 formC40 { get; set; }
            public Formc411 formC41 { get; set; }
            public Formc421 formC42 { get; set; }
            public Formc431 formC43 { get; set; }
            public Formc441 formC44 { get; set; }
            public Formc451 formC45 { get; set; }
            public Formc461 formC46 { get; set; }
            public Formc471 formC47 { get; set; }
            public Formc481 formC48 { get; set; }
            public Formc491 formC49 { get; set; }
            public Formc510 formC5 { get; set; }
            public Formc501 formC50 { get; set; }
            public Formc511 formC51 { get; set; }
            public Formc521 formC52 { get; set; }
            public Formc531 formC53 { get; set; }
            public Formc541 formC54 { get; set; }
            public Formc551 formC55 { get; set; }
            public Formc561 formC56 { get; set; }
            public Formc571 formC57 { get; set; }
            public Formc581 formC58 { get; set; }
            public Formc591 formC59 { get; set; }
            public Formc610 formC6 { get; set; }
            public Formc601 formC60 { get; set; }
            public Formc611 formC61 { get; set; }
            public Formc621 formC62 { get; set; }
            public Formc631 formC63 { get; set; }
            public Formc641 formC64 { get; set; }
            public Formc651 formC65 { get; set; }
            public Formc661 formC66 { get; set; }
            public Formc671 formC67 { get; set; }
            public Formc681 formC68 { get; set; }
            public Formc691 formC69 { get; set; }
            public Formc710 formC7 { get; set; }
            public Formc701 formC70 { get; set; }
            public Formc711 formC71 { get; set; }
            public Formc721 formC72 { get; set; }
            public Formc731 formC73 { get; set; }
            public Formc741 formC74 { get; set; }
            public Formc751 formC75 { get; set; }
            public Formc761 formC76 { get; set; }
            public Formc771 formC77 { get; set; }
            public Formc781 formC78 { get; set; }
            public Formc791 formC79 { get; set; }
            public Formc810 formC8 { get; set; }
            public Formc801 formC80 { get; set; }
            public Formc811 formC81 { get; set; }
            public Formc821 formC82 { get; set; }
            public Formc831 formC83 { get; set; }
            public Formc841 formC84 { get; set; }
            public Formc851 formC85 { get; set; }
            public Formc861 formC86 { get; set; }
            public Formc871 formC87 { get; set; }
            public Formc881 formC88 { get; set; }
            public Formc891 formC89 { get; set; }
            public Formc910 formC9 { get; set; }
            public Formc901 formC90 { get; set; }
            public Formc911 formC91 { get; set; }
            public Formc921 formC92 { get; set; }
            public Formc931 formC93 { get; set; }
            public Formc941 formC94 { get; set; }
            public Formc951 formC95 { get; set; }
            public Formc961 formC96 { get; set; }
            public Formc971 formC97 { get; set; }
            public Formc981 formC98 { get; set; }
            public Formc991 formC99 { get; set; }
            public Formu110 formU1 { get; set; }
            public Formu101 formU10 { get; set; }
            public Formu1001 formU100 { get; set; }
            public Formu111 formU11 { get; set; }
            public Formu121 formU12 { get; set; }
            public Formu131 formU13 { get; set; }
            public Formu141 formU14 { get; set; }
            public Formu151 formU15 { get; set; }
            public Formu161 formU16 { get; set; }
            public Formu171 formU17 { get; set; }
            public Formu181 formU18 { get; set; }
            public Formu191 formU19 { get; set; }
            public Formu210 formU2 { get; set; }
            public Formu201 formU20 { get; set; }
            public Formu211 formU21 { get; set; }
            public Formu221 formU22 { get; set; }
            public Formu231 formU23 { get; set; }
            public Formu241 formU24 { get; set; }
            public Formu251 formU25 { get; set; }
            public Formu261 formU26 { get; set; }
            public Formu271 formU27 { get; set; }
            public Formu281 formU28 { get; set; }
            public Formu291 formU29 { get; set; }
            public Formu310 formU3 { get; set; }
            public Formu301 formU30 { get; set; }
            public Formu311 formU31 { get; set; }
            public Formu321 formU32 { get; set; }
            public Formu331 formU33 { get; set; }
            public Formu341 formU34 { get; set; }
            public Formu351 formU35 { get; set; }
            public Formu361 formU36 { get; set; }
            public Formu371 formU37 { get; set; }
            public Formu381 formU38 { get; set; }
            public Formu391 formU39 { get; set; }
            public Formu410 formU4 { get; set; }
            public Formu401 formU40 { get; set; }
            public Formu411 formU41 { get; set; }
            public Formu421 formU42 { get; set; }
            public Formu431 formU43 { get; set; }
            public Formu441 formU44 { get; set; }
            public Formu451 formU45 { get; set; }
            public Formu461 formU46 { get; set; }
            public Formu471 formU47 { get; set; }
            public Formu481 formU48 { get; set; }
            public Formu491 formU49 { get; set; }
            public Formu510 formU5 { get; set; }
            public Formu501 formU50 { get; set; }
            public Formu511 formU51 { get; set; }
            public Formu521 formU52 { get; set; }
            public Formu531 formU53 { get; set; }
            public Formu541 formU54 { get; set; }
            public Formu551 formU55 { get; set; }
            public Formu561 formU56 { get; set; }
            public Formu571 formU57 { get; set; }
            public Formu581 formU58 { get; set; }
            public Formu591 formU59 { get; set; }
            public Formu610 formU6 { get; set; }
            public Formu601 formU60 { get; set; }
            public Formu611 formU61 { get; set; }
            public Formu621 formU62 { get; set; }
            public Formu631 formU63 { get; set; }
            public Formu641 formU64 { get; set; }
            public Formu651 formU65 { get; set; }
            public Formu661 formU66 { get; set; }
            public Formu671 formU67 { get; set; }
            public Formu681 formU68 { get; set; }
            public Formu691 formU69 { get; set; }
            public Formu710 formU7 { get; set; }
            public Formu701 formU70 { get; set; }
            public Formu711 formU71 { get; set; }
            public Formu721 formU72 { get; set; }
            public Formu731 formU73 { get; set; }
            public Formu741 formU74 { get; set; }
            public Formu751 formU75 { get; set; }
            public Formu761 formU76 { get; set; }
            public Formu771 formU77 { get; set; }
            public Formu781 formU78 { get; set; }
            public Formu791 formU79 { get; set; }
            public Formu810 formU8 { get; set; }
            public Formu801 formU80 { get; set; }
            public Formu811 formU81 { get; set; }
            public Formu821 formU82 { get; set; }
            public Formu831 formU83 { get; set; }
            public Formu841 formU84 { get; set; }
            public Formu851 formU85 { get; set; }
            public Formu861 formU86 { get; set; }
            public Formu871 formU87 { get; set; }
            public Formu881 formU88 { get; set; }
            public Formu891 formU89 { get; set; }
            public Formu910 formU9 { get; set; }
            public Formu901 formU90 { get; set; }
            public Formu911 formU91 { get; set; }
            public Formu921 formU92 { get; set; }
            public Formu931 formU93 { get; set; }
            public Formu941 formU94 { get; set; }
            public Formu951 formU95 { get; set; }
            public Formu961 formU96 { get; set; }
            public Formu971 formU97 { get; set; }
            public Formu981 formU98 { get; set; }
            public Formu991 formU99 { get; set; }
            public _12X261 _12x26 { get; set; }
            public _1433X261 _1433x26 { get; set; }
            public _143X2051 _143x205 { get; set; }
            public _143X2251 _143x225 { get; set; }
            public _9X111 _9x11 { get; set; }
            public _9X11r1 _9x11R { get; set; }
            public A31 A3 { get; set; }
            public A41 A4 { get; set; }
            public A4oversizedtab1 A4OverSizedTab { get; set; }
            public A4oversizedtabr1 A4OverSizedTabR { get; set; }
            public A4R1 A4R { get; set; }
            public B41 B4 { get; set; }
            public B4R1 B4R { get; set; }
            public Fanfoldgermanlegal1 FanFoldGermanLegal { get; set; }
            public Fanfoldgermanlegalr1 FanFoldGermanLegalR { get; set; }
            public ISOB31 ISOB3 { get; set; }
            public ISOB41 ISOB4 { get; set; }
            public ISOB4R1 ISOB4R { get; set; }
            public Legal1 Legal { get; set; }
            public Legalr1 LegalR { get; set; }
            public Letter1 Letter { get; set; }
            public Letterr1 LetterR { get; set; }
            public SRA31 SRA3 { get; set; }
            public Tabloid1 Tabloid { get; set; }
            public Tabloidextra1 TabloidExtra { get; set; }
            public object custom { get; set; }
        }

        public class False1
        {
            public string[] EFDFAProfile { get; set; }
            public string[] EFControlBar { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFMltClrPrntMap { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFOutputBin { get; set; }
            public string[] EFTabEjectTray { get; set; }
            public string[] EFImageAlign { get; set; }
            public string[] EFMMCover { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFColorMode { get; set; }
            public string[] EFColorant1Enable { get; set; }
            public string[] EFColorant1Graphic { get; set; }
            public string[] EFColorant1Image { get; set; }
            public string[] EFColorant1Spot { get; set; }
            public string[] EFColorant1Text { get; set; }
            public string[] EFPCPadCover { get; set; }
        }

        public class True1
        {
            public string[] EFDFAProfile { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFCreateMaster { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFUseSPDMediaMapping { get; set; }
            public string[] PageSize { get; set; }
            public string[] EFMltClrPrntMap { get; set; }
            public string[] EFColorMode { get; set; }
            public string[] EFCompOverprint { get; set; }
            public string[] EFGAFeaturesOpt { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSubstColors { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFBlkOvpCtrl { get; set; }
            public string[] EFPDFXobjects { get; set; }
            public string[] EFSpotColors { get; set; }
            public string[] EFUseMaster { get; set; }
            public string[] EFColorant1RipOptions { get; set; }
            public string[] EFPadPrinting { get; set; }
            public string[] EFDuplex { get; set; }
            public string[] EFPageDelivery { get; set; }
            public string[] EFSlipsheet { get; set; }
            public string[] EFSubsetFinishingInUse { get; set; }
            public string[] EFOutputBin { get; set; }
            public string[] EFMMInsType { get; set; }
        }

        public class Stacker11
        {
            public string[] EFOutputBin { get; set; }
            public string[] EFTabEjectTray { get; set; }
        }

        public class Stacker21
        {
            public string[] EFOutputBin { get; set; }
            public string[] EFTabEjectTray { get; set; }
            public string[] EFOpt_Finisher_HCSTray { get; set; }
            public string[] EFDFAProfile { get; set; }
            public string[] EFMediaWeight { get; set; }
        }

        public class Stacker31
        {
            public string[] EFOutputBin { get; set; }
            public string[] EFTabEjectTray { get; set; }
            public string[] EFOpt_Finisher_HCSTray { get; set; }
            public string[] EFDFAProfile { get; set; }
            public string[] EFMediaWeight { get; set; }
        }

        public class Stacker41
        {
            public string[] EFOpt_Finisher_HCSTray { get; set; }
            public string[] EFDFAProfile { get; set; }
            public string[] EFMediaWeight { get; set; }
        }

        public class Toptray11
        {
            public string[] EFOutputBin { get; set; }
            public string[] EFTabEjectTray { get; set; }
        }

        public class Toptray21
        {
            public string[] EFOutputBin { get; set; }
            public string[] EFTabEjectTray { get; set; }
        }

        public class Toptray31
        {
            public string[] EFOutputBin { get; set; }
            public string[] EFTabEjectTray { get; set; }
        }

        public class All1
        {
            public string[] EFColorMode { get; set; }
            public string[] EFCreateMaster { get; set; }
            public string[] EFGAFeaturesOpt { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSubstColors { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Even1
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFDuplex { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFMMInsType { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSubsetFinishingInUse { get; set; }
        }

        public class Odd1
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFDuplex { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFMMInsType { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSubsetFinishingInUse { get; set; }
        }

        public class Range11
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFSubsetFinishingInUse { get; set; }
        }

        public class Colorcodedjob1
        {
            public string[] EFColorMode { get; set; }
            public string[] EFCreateMaster { get; set; }
            public string[] EFGAFeaturesOpt { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSubstColors { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Reportconcise1
        {
            public string[] EFColorMode { get; set; }
            public string[] EFCreateMaster { get; set; }
            public string[] EFGAFeaturesOpt { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSubstColors { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Testpage1
        {
            public string[] EFColorMode { get; set; }
            public string[] EFCreateMaster { get; set; }
            public string[] EFGAFeaturesOpt { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSubstColors { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Plain1
        {
            public string[] EFMediaColor { get; set; }
        }

        public class Preprinted2
        {
            public string[] EFMediaColor { get; set; }
        }

        public class Tabpaper11
        {
            public string[] EFMediaColor { get; set; }
        }

        public class Tabpaper21
        {
            public string[] EFMediaColor { get; set; }
        }

        public class Tabstock1
        {
            public string[] EFMediaColor { get; set; }
        }

        public class Transparency1
        {
            public string[] EFDuplex { get; set; }
        }

        public class Gsm_1805301
        {
            public string[] EFOutputBin { get; set; }
        }

        public class Clear1
        {
            public string[] EFMediaType { get; set; }
            public string[] EFColorant1_NumLayers { get; set; }
        }

        public class Blank1
        {
            public string[] EFPageRange { get; set; }
        }

        public class None1
        {
            public string[] EFOutputBin { get; set; }
            public string[] EFEnhancedFF { get; set; }
        }

        public class Tab1
        {
            public string[] CustomPageSize { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] PageSize { get; set; }
        }

        public class Printback1
        {
            public string[] EFDuplex { get; set; }
        }

        public class Printboth1
        {
            public string[] EFDuplex { get; set; }
        }

        public class Bypass1
        {
            public string[] EFOpt_Finisher_BypassTray { get; set; }
            public string[] EFDFAProfile { get; set; }
            public string[] EFOffsetWithinJob { get; set; }
        }

        public class Stacker5
        {
            public string[] EFDFAProfile { get; set; }
            public string[] EFMediaWeight { get; set; }
            public string[] EFOpt_Finisher_HCSTray { get; set; }
        }

        public class Stackerauto1
        {
            public string[] EFDFAProfile { get; set; }
            public string[] EFMediaWeight { get; set; }
            public string[] EFOpt_Finisher_HCSTray { get; set; }
        }

        public class Top1
        {
            public string[] EFDFAProfile { get; set; }
            public string[] EFOffsetWithinJob { get; set; }
            public string[] EFOpt_Finisher_TopTray { get; set; }
        }

        public class Top21
        {
            public string[] EFOpt_Finisher_TopTray { get; set; }
            public string[] EFDFAProfile { get; set; }
            public string[] EFOffsetWithinJob { get; set; }
        }

        public class Top31
        {
            public string[] EFOpt_Finisher_TopTray { get; set; }
            public string[] EFDFAProfile { get; set; }
            public string[] EFOffsetWithinJob { get; set; }
        }

        public class Top41
        {
            public string[] EFOpt_Finisher_TopTray { get; set; }
            public string[] EFDFAProfile { get; set; }
            public string[] EFOffsetWithinJob { get; set; }
        }

        public class Toptrayauto1
        {
            public string[] EFDFAProfile { get; set; }
            public string[] EFOffsetWithinJob { get; set; }
            public string[] EFOpt_Finisher_TopTray { get; set; }
        }

        public class Topbottom1
        {
            public string[] EFMediaType { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFRIPBooklet { get; set; }
        }

        public class Toptop1
        {
            public string[] EFMediaType { get; set; }
            public string[] EFPageRange { get; set; }
        }

        public class _16ULH1
        {
            public string[] EFAutoScaling { get; set; }
            public string[] EFCreateMaster { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFSubsetFinishingInUse { get; set; }
            public string[] EFUseMaster { get; set; }
            public string[] EFUserRotate180 { get; set; }
        }

        public class _16ULV1
        {
            public string[] EFAutoScaling { get; set; }
            public string[] EFCreateMaster { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFSubsetFinishingInUse { get; set; }
            public string[] EFUseMaster { get; set; }
            public string[] EFUserRotate180 { get; set; }
        }

        public class _16URH1
        {
            public string[] EFAutoScaling { get; set; }
            public string[] EFCreateMaster { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFSubsetFinishingInUse { get; set; }
            public string[] EFUseMaster { get; set; }
            public string[] EFUserRotate180 { get; set; }
        }

        public class _16URV1
        {
            public string[] EFAutoScaling { get; set; }
            public string[] EFCreateMaster { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFSubsetFinishingInUse { get; set; }
            public string[] EFUseMaster { get; set; }
            public string[] EFUserRotate180 { get; set; }
        }

        public class _1UP1
        {
            public string[] EFNUpBoundingBox { get; set; }
        }

        public class _2ULH1
        {
            public string[] EFAutoScaling { get; set; }
            public string[] EFCreateMaster { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFSubsetFinishingInUse { get; set; }
            public string[] EFUseMaster { get; set; }
            public string[] EFUserRotate180 { get; set; }
        }

        public class _2ULV1
        {
            public string[] EFAutoScaling { get; set; }
            public string[] EFCreateMaster { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFSubsetFinishingInUse { get; set; }
            public string[] EFUseMaster { get; set; }
            public string[] EFUserRotate180 { get; set; }
        }

        public class _2URH1
        {
            public string[] EFAutoScaling { get; set; }
            public string[] EFCreateMaster { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFSubsetFinishingInUse { get; set; }
            public string[] EFUseMaster { get; set; }
            public string[] EFUserRotate180 { get; set; }
        }

        public class _2URV1
        {
            public string[] EFAutoScaling { get; set; }
            public string[] EFCreateMaster { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFSubsetFinishingInUse { get; set; }
            public string[] EFUseMaster { get; set; }
            public string[] EFUserRotate180 { get; set; }
        }

        public class _4ULH1
        {
            public string[] EFAutoScaling { get; set; }
            public string[] EFCreateMaster { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFSubsetFinishingInUse { get; set; }
            public string[] EFUseMaster { get; set; }
            public string[] EFUserRotate180 { get; set; }
        }

        public class _4ULV1
        {
            public string[] EFAutoScaling { get; set; }
            public string[] EFCreateMaster { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFSubsetFinishingInUse { get; set; }
            public string[] EFUseMaster { get; set; }
            public string[] EFUserRotate180 { get; set; }
        }

        public class _4URH1
        {
            public string[] EFAutoScaling { get; set; }
            public string[] EFCreateMaster { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFSubsetFinishingInUse { get; set; }
            public string[] EFUseMaster { get; set; }
            public string[] EFUserRotate180 { get; set; }
        }

        public class _4URV1
        {
            public string[] EFAutoScaling { get; set; }
            public string[] EFCreateMaster { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFSubsetFinishingInUse { get; set; }
            public string[] EFUseMaster { get; set; }
            public string[] EFUserRotate180 { get; set; }
        }

        public class _6ULH1
        {
            public string[] EFAutoScaling { get; set; }
            public string[] EFCreateMaster { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFSubsetFinishingInUse { get; set; }
            public string[] EFUseMaster { get; set; }
            public string[] EFUserRotate180 { get; set; }
        }

        public class _6ULV1
        {
            public string[] EFAutoScaling { get; set; }
            public string[] EFCreateMaster { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFSubsetFinishingInUse { get; set; }
            public string[] EFUseMaster { get; set; }
            public string[] EFUserRotate180 { get; set; }
        }

        public class _6URH1
        {
            public string[] EFAutoScaling { get; set; }
            public string[] EFCreateMaster { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFSubsetFinishingInUse { get; set; }
            public string[] EFUseMaster { get; set; }
            public string[] EFUserRotate180 { get; set; }
        }

        public class _6URV1
        {
            public string[] EFAutoScaling { get; set; }
            public string[] EFCreateMaster { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFSubsetFinishingInUse { get; set; }
            public string[] EFUseMaster { get; set; }
            public string[] EFUserRotate180 { get; set; }
        }

        public class _9ULH1
        {
            public string[] EFAutoScaling { get; set; }
            public string[] EFCreateMaster { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFSubsetFinishingInUse { get; set; }
            public string[] EFUseMaster { get; set; }
            public string[] EFUserRotate180 { get; set; }
        }

        public class _9ULV1
        {
            public string[] EFAutoScaling { get; set; }
            public string[] EFCreateMaster { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFSubsetFinishingInUse { get; set; }
            public string[] EFUseMaster { get; set; }
            public string[] EFUserRotate180 { get; set; }
        }

        public class _9URH1
        {
            public string[] EFAutoScaling { get; set; }
            public string[] EFCreateMaster { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFSubsetFinishingInUse { get; set; }
            public string[] EFUseMaster { get; set; }
            public string[] EFUserRotate180 { get; set; }
        }

        public class _9URV1
        {
            public string[] EFAutoScaling { get; set; }
            public string[] EFCreateMaster { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFSubsetFinishingInUse { get; set; }
            public string[] EFUseMaster { get; set; }
            public string[] EFUserRotate180 { get; set; }
        }

        public class Double1
        {
            public string[] EFAutoScaling { get; set; }
            public string[] EFCreateMaster { get; set; }
            public string[] EFDuplex { get; set; }
            public string[] EFImageFlag { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFSubsetFinishingInUse { get; set; }
            public string[] EFUseMaster { get; set; }
            public string[] EFUserRotate180 { get; set; }
        }

        public class Nestsaddlel1
        {
            public string[] EFAutoScaling { get; set; }
            public string[] EFCreateMaster { get; set; }
            public string[] EFDuplex { get; set; }
            public string[] EFImageFlag { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFSubsetFinishingInUse { get; set; }
            public string[] EFUseMaster { get; set; }
            public string[] EFUserRotate180 { get; set; }
        }

        public class Nestsaddler1
        {
            public string[] EFAutoScaling { get; set; }
            public string[] EFCreateMaster { get; set; }
            public string[] EFDuplex { get; set; }
            public string[] EFImageFlag { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFSubsetFinishingInUse { get; set; }
            public string[] EFUseMaster { get; set; }
            public string[] EFUserRotate180 { get; set; }
        }

        public class Nestsaddlet1
        {
            public string[] EFAutoScaling { get; set; }
            public string[] EFCreateMaster { get; set; }
            public string[] EFDuplex { get; set; }
            public string[] EFImageFlag { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFSubsetFinishingInUse { get; set; }
            public string[] EFUseMaster { get; set; }
            public string[] EFUserRotate180 { get; set; }
        }

        public class Perfect1
        {
            public string[] EFAutoScaling { get; set; }
            public string[] EFCreateMaster { get; set; }
            public string[] EFDuplex { get; set; }
            public string[] EFImageFlag { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFSubsetFinishingInUse { get; set; }
            public string[] EFUseMaster { get; set; }
            public string[] EFUserRotate180 { get; set; }
        }

        public class Perfectright1
        {
            public string[] EFAutoScaling { get; set; }
            public string[] EFCreateMaster { get; set; }
            public string[] EFDuplex { get; set; }
            public string[] EFImageFlag { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFSubsetFinishingInUse { get; set; }
            public string[] EFUseMaster { get; set; }
            public string[] EFUserRotate180 { get; set; }
        }

        public class Perfecttop1
        {
            public string[] EFAutoScaling { get; set; }
            public string[] EFCreateMaster { get; set; }
            public string[] EFDuplex { get; set; }
            public string[] EFImageFlag { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFSubsetFinishingInUse { get; set; }
            public string[] EFUseMaster { get; set; }
            public string[] EFUserRotate180 { get; set; }
        }

        public class Speed1
        {
            public string[] EFAutoScaling { get; set; }
            public string[] EFCreateMaster { get; set; }
            public string[] EFDuplex { get; set; }
            public string[] EFImageFlag { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFSubsetFinishingInUse { get; set; }
            public string[] EFUseMaster { get; set; }
            public string[] EFUserRotate180 { get; set; }
        }

        public class Twoup1
        {
            public string[] EFAutoScaling { get; set; }
            public string[] EFCreateMaster { get; set; }
            public string[] EFDuplex { get; set; }
            public string[] EFImageFlag { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFSubsetFinishingInUse { get; set; }
            public string[] EFUseMaster { get; set; }
            public string[] EFUserRotate180 { get; set; }
        }

        public class Twoupright1
        {
            public string[] EFAutoScaling { get; set; }
            public string[] EFCreateMaster { get; set; }
            public string[] EFDuplex { get; set; }
            public string[] EFImageFlag { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFSubsetFinishingInUse { get; set; }
            public string[] EFUseMaster { get; set; }
            public string[] EFUserRotate180 { get; set; }
        }

        public class Twouptop1
        {
            public string[] EFAutoScaling { get; set; }
            public string[] EFCreateMaster { get; set; }
            public string[] EFDuplex { get; set; }
            public string[] EFImageFlag { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFSubsetFinishingInUse { get; set; }
            public string[] EFUseMaster { get; set; }
            public string[] EFUserRotate180 { get; set; }
        }

        public class CMYKPLUS1
        {
            public string[] EFColorant1Enable { get; set; }
            public string[] EFCompOverprint { get; set; }
            public string[] EFHTGraphics { get; set; }
            public string[] EFHTImages { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFHTText { get; set; }
            public string[] EFMltClrPrntMap { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSubstColors { get; set; }
        }

        public class Grayscale1
        {
            public string[] EFMltClrPrntMap { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFTrapping { get; set; }
        }

        public class SEPSIM1
        {
            public string[] EFKOnlyGrayRGB { get; set; }
        }

        public class BLACKNORMAL1
        {
            public string[] EFBlkOvpCtrl { get; set; }
        }

        public class OFF2
        {
            public string[] EFSeparations { get; set; }
        }

        public class TEXTGRAPHICS1
        {
            public string[] EFPureBlack { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFRGBSep { get; set; }
        }

        public class TEXTONLY1
        {
            public string[] EFPureBlack { get; set; }
            public string[] EFSeparations { get; set; }
        }

        public class TEXTGRAPHICSIMAG1
        {
            public string[] EFRGBSep { get; set; }
        }

        public class MATCHCOPY1
        {
            public string[] EFCurveAdjust { get; set; }
        }

        public class Nocorrection1
        {
            public string[] EFSimulation { get; set; }
        }

        public class Cmykarea1
        {
            public string[] EFColorant1RipOptions { get; set; }
        }

        public class _21
        {
            public string[] EFColorant1Rip { get; set; }
            public string[] EFColorant1RipOptions { get; set; }
        }

        public class Screen11
        {
            public string[] EFColorMode { get; set; }
            public string[] EFCreateMaster { get; set; }
            public string[] EFGAFeaturesOpt { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Screen21
        {
            public string[] EFColorMode { get; set; }
            public string[] EFCreateMaster { get; set; }
            public string[] EFGAFeaturesOpt { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Screen31
        {
            public string[] EFColorMode { get; set; }
            public string[] EFCreateMaster { get; set; }
            public string[] EFGAFeaturesOpt { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Appdef1
        {
            public string[] EFColorMode { get; set; }
            public string[] EFCreateMaster { get; set; }
            public string[] EFGAFeaturesOpt { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Newsprint1
        {
            public string[] EFColorMode { get; set; }
            public string[] EFCreateMaster { get; set; }
            public string[] EFGAFeaturesOpt { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Reverseorderfacedown1
        {
            public string[] EFPadPrinting { get; set; }
        }

        public class Reverseorderfaceup1
        {
            public string[] EFPadPrinting { get; set; }
        }

        public class Sameorderfaceup1
        {
            public string[] EFPadPrinting { get; set; }
        }

        public class Finisher1
        {
            public string[] EFDFAProfile { get; set; }
            public string[] EFOffsetWithinJob { get; set; }
        }

        public class Profile11
        {
            public string[] EFDocFinisherArchitecture { get; set; }
            public string[] EFOpt_Finisher_BypassTray { get; set; }
            public string[] EFOutputBin { get; set; }
        }

        public class Profile21
        {
            public string[] EFDocFinisherArchitecture { get; set; }
            public string[] EFOpt_Finisher_BypassTray { get; set; }
            public string[] EFOutputBin { get; set; }
        }

        public class Profile31
        {
            public string[] EFDocFinisherArchitecture { get; set; }
            public string[] EFOpt_Finisher_BypassTray { get; set; }
            public string[] EFOutputBin { get; set; }
        }

        public class Profile41
        {
            public string[] EFDocFinisherArchitecture { get; set; }
            public string[] EFOpt_Finisher_BypassTray { get; set; }
            public string[] EFOutputBin { get; set; }
        }

        public class Formc110
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc101
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc1001
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc111
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc121
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc131
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc141
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc151
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc161
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc171
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc181
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc191
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc210
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc201
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc211
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc221
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc231
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc241
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc251
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc261
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc271
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc281
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc291
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc310
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc301
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc311
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc321
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc331
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc341
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc351
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc361
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc371
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc381
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc391
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc410
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc401
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc411
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc421
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc431
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc441
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc451
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc461
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc471
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc481
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc491
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc510
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc501
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc511
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc521
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc531
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc541
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc551
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc561
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc571
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc581
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc591
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc610
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc601
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc611
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc621
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc631
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc641
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc651
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc661
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc671
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc681
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc691
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc710
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc701
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc711
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc721
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc731
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc741
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc751
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc761
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc771
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc781
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc791
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc810
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc801
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc811
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc821
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc831
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc841
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc851
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc861
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc871
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc881
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc891
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc910
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc901
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc911
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc921
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc931
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc941
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc951
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc961
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc971
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc981
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formc991
        {
            public string[] EFHTScreen { get; set; }
            public string[] EFMMInUse { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPageRange { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
            public string[] EFUseMaster { get; set; }
        }

        public class Formu110
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu101
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu1001
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu111
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu121
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu131
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu141
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu151
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu161
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu171
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu181
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu191
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu210
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu201
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu211
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu221
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu231
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu241
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu251
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu261
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu271
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu281
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu291
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu310
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu301
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu311
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu321
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu331
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu341
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu351
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu361
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu371
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu381
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu391
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu410
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu401
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu411
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu421
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu431
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu441
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu451
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu461
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu471
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu481
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu491
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu510
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu501
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu511
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu521
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu531
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu541
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu551
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu561
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu571
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu581
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu591
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu610
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu601
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu611
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu621
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu631
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu641
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu651
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu661
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu671
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu681
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu691
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu710
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu701
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu711
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu721
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu731
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu741
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu751
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu761
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu771
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu781
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu791
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu810
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu801
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu811
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu821
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu831
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu841
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu851
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu861
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu871
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu881
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu891
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu910
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu901
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu911
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu921
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu931
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu941
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu951
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu961
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu971
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu981
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class Formu991
        {
            public string[] EFCreateMaster { get; set; }
            public string[] EFHTScreen { get; set; }
            public string[] EFNUpOption { get; set; }
            public string[] EFPostFlight { get; set; }
            public string[] EFRIPBooklet { get; set; }
            public string[] EFSeparations { get; set; }
            public string[] EFSplitToRec { get; set; }
        }

        public class _12X261
        {
            public string[] EFMMInsType { get; set; }
            public string[] EFOffsetWithinJob { get; set; }
        }

        public class _1433X261
        {
            public string[] EFMMInsType { get; set; }
            public string[] EFOffsetWithinJob { get; set; }
        }

        public class _143X2051
        {
            public string[] EFMMInsType { get; set; }
        }

        public class _143X2251
        {
            public string[] EFMMInsType { get; set; }
        }

        public class _9X111
        {
            public string[] EFAutoScaling { get; set; }
        }

        public class _9X11r1
        {
            public string[] EFAutoScaling { get; set; }
        }

        public class A31
        {
            public string[] EFMMInsType { get; set; }
            public string[] EFMMTabShift { get; set; }
        }

        public class A41
        {
            public string[] EFMMInsType { get; set; }
            public string[] EFMMTabShift { get; set; }
        }

        public class A4oversizedtab1
        {
            public string[] EFAutoScaling { get; set; }
        }

        public class A4oversizedtabr1
        {
            public string[] EFAutoScaling { get; set; }
        }

        public class A4R1
        {
            public string[] EFMMInsType { get; set; }
            public string[] EFMMTabShift { get; set; }
        }

        public class B41
        {
            public string[] EFMMInsType { get; set; }
            public string[] EFMMTabShift { get; set; }
        }

        public class B4R1
        {
            public string[] EFMMInsType { get; set; }
        }

        public class Fanfoldgermanlegal1
        {
            public string[] EFMMInsType { get; set; }
        }

        public class Fanfoldgermanlegalr1
        {
            public string[] EFMMInsType { get; set; }
        }

        public class ISOB31
        {
            public string[] EFMMInsType { get; set; }
        }

        public class ISOB41
        {
            public string[] EFMMInsType { get; set; }
            public string[] EFMMTabShift { get; set; }
        }

        public class ISOB4R1
        {
            public string[] EFMMInsType { get; set; }
        }

        public class Legal1
        {
            public string[] EFMMInsType { get; set; }
            public string[] EFMMTabShift { get; set; }
        }

        public class Legalr1
        {
            public string[] EFMMInsType { get; set; }
        }

        public class Letter1
        {
            public string[] EFMMInsType { get; set; }
            public string[] EFMMTabShift { get; set; }
        }

        public class Letterr1
        {
            public string[] EFMMInsType { get; set; }
            public string[] EFMMTabShift { get; set; }
        }

        public class SRA31
        {
            public string[] EFMMInsType { get; set; }
            public string[] EFMMTabShift { get; set; }
        }

        public class Tabloid1
        {
            public string[] EFMMInsType { get; set; }
            public string[] EFMMTabShift { get; set; }
        }

        public class Tabloidextra1
        {
            public string[] EFMMInsType { get; set; }
            public string[] EFMMTabShift { get; set; }
        }

        public class Links
        {
            public string rel { get; set; }
            public string href { get; set; }
        }
    }
}
