﻿using UnityEngine;
using System.Collections;
using BaPK;

public class Social2FontRead : MonoBehaviour {


    public Texture2D textureFont;
    private BitmapFont bitmapFont;
    public Label labelFont;

    private string nameSorttingLayer;
    private int sorttingOrderInLayer;
    private TextAlignment alignment;
    private string value;
    private float kerning;
    private float space;
    private bool isUpdate;
    void Start()
    {
        #region lines for font
  string[] lines = new string[]{
	"40 183 19 18 42 20 A",
	"0 212 19 22 38 20 Á",
	"20 230 19 22 38 20 À",
	"0 257 19 23 37 20 Ả",
	"0 235 19 21 39 20 Ã",
	"20 115 19 21 42 20 Ạ",
	"0 115 19 21 39 20 Ă",
	"0 137 19 24 36 20 Ắ",
	"0 162 19 24 36 20 Ằ",
	"0 187 19 24 36 20 Ẳ",
	"22 53 19 23 37 20 Ẵ",
	"25 0 19 24 39 20 Ặ",
	"20 137 19 21 39 20 Â",
	"20 159 19 22 38 20 Ấ",
	"20 182 19 22 38 20 Ầ",
	"20 205 19 24 36 20 Ẩ",
	"40 134 19 23 37 20 Ẫ",
	"20 253 19 24 39 20 Ậ",
	"235 70 14 18 42 15 E",
	"235 0 14 22 38 15 É",
	"235 23 14 22 38 15 È",
	"235 89 14 23 37 15 Ẻ",
	"250 25 14 21 39 15 Ẽ",
	"250 69 14 22 42 15 Ẹ",
	"250 47 14 21 39 15 Ê",
	"202 105 16 22 38 17 Ế",
	"202 192 16 22 38 17 Ề",
	"250 0 14 24 36 15 Ể",
	"235 46 14 23 37 15 Ễ",
	"235 113 14 25 39 15 Ệ",
	"272 208 7 18 42 8 I",
	"262 185 10 22 38 11 Í",
	"264 92 9 22 38 10 Ì",
	"272 160 7 23 37 8 Ỉ",
	"264 138 8 21 39 9 Ĩ",
	"271 227 7 22 42 8 Ị",
	"60 68 18 19 41 19 O",
	"98 137 17 22 38 18 Ó",
	"59 246 18 22 38 19 Ò",
	"115 244 17 23 37 18 Ỏ",
	"119 0 17 22 38 18 Õ",
	"41 77 18 23 41 19 Ọ",
	"116 104 17 21 39 18 Ô",
	"42 44 18 23 37 19 Ố",
	"40 246 18 23 37 19 Ồ",
	"134 40 17 24 36 18 Ổ",
	"45 0 18 24 36 19 Ỗ",
	"60 88 18 25 39 19 Ộ",
	"133 253 17 20 40 18 Ơ",
	"60 114 18 22 38 19 Ớ",
	"97 212 17 22 38 18 Ờ",
	"79 191 17 23 37 18 Ở",
	"60 198 18 22 38 19 Ỡ",
	"79 215 17 24 40 18 Ợ",
	"64 0 18 18 42 19 Y",
	"80 41 17 21 39 18 Ý",
	"79 169 17 21 39 18 Ỳ",
	"97 169 17 22 38 18 Ỷ",
	"83 0 17 21 39 18 Ỹ",
	"79 84 18 22 42 19 Ỵ",
	"83 22 17 18 42 18 U",
	"202 170 16 21 39 17 Ú",
	"97 256 17 21 39 18 Ù",
	"133 149 17 22 38 18 Ủ",
	"202 128 16 21 39 17 Ũ",
	"116 126 17 22 42 18 Ụ",
	"79 126 18 20 40 19 Ư",
	"64 19 18 21 39 19 Ứ",
	"40 202 19 21 39 20 Ừ",
	"60 137 18 22 38 19 Ử",
	"40 224 19 21 39 20 Ữ",
	"40 158 19 24 40 20 Ự",
	"133 213 17 18 42 18 B",
	"218 238 15 18 42 16 C",
	"60 179 18 18 42 19 D",
	"40 115 19 18 42 20 Đ",
	"235 158 14 18 42 15 F",
	"202 150 16 19 41 17 G",
	"98 99 17 18 42 18 H",
	"250 222 11 18 42 12 J",
	"45 25 18 18 42 19 K",
	"250 111 13 18 42 14 L",
	"0 53 21 18 42 22 M",
	"133 194 17 18 42 18 N",
	"98 41 17 18 42 18 P",
	"98 60 17 21 41 18 Q",
	"60 160 18 18 42 19 R",
	"202 234 15 18 42 16 S",
	"185 192 16 18 42 17 T",
	"98 118 17 18 42 18 V",
	"0 0 24 18 42 25 W",
	"25 25 19 18 42 20 X",
	"202 215 15 18 42 16 Z",
	"168 262 16 16 44 17 a",
	"185 85 16 19 41 17 á",
	"218 257 15 19 41 16 à",
	"185 44 16 20 40 17 ả",
	"171 0 16 19 41 17 ã",
	"169 23 16 20 44 17 ạ",
	"168 242 16 19 41 17 ă",
	"202 253 15 21 39 16 ắ",
	"168 197 16 21 39 17 ằ",
	"168 174 16 22 38 17 ẳ",
	"168 152 16 21 39 17 ẵ",
	"168 128 16 23 41 17 ặ",
	"203 17 15 18 42 16 â",
	"116 62 17 20 40 18 ấ",
	"133 232 17 20 40 18 ầ",
	"154 0 16 22 38 17 ẩ",
	"202 83 16 21 39 17 ẫ",
	"218 215 15 22 42 16 ậ",
	"137 21 16 16 44 17 e",
	"151 232 16 20 40 17 é",
	"151 211 16 20 40 17 è",
	"151 189 16 21 39 17 ẻ",
	"151 169 16 19 41 17 ẽ",
	"185 105 16 20 44 17 ẹ",
	"151 125 16 19 41 17 ê",
	"60 221 18 20 40 19 ế",
	"97 235 17 20 40 18 ề",
	"168 219 16 22 38 17 ể",
	"168 61 16 21 39 17 ễ",
	"168 104 16 23 41 17 ệ",
	"265 19 7 19 41 8 i",
	"263 261 9 19 41 10 í",
	"261 241 9 19 41 10 ì",
	"273 250 6 20 40 7 ỉ",
	"262 208 9 18 42 10 ĩ",
	"273 131 6 23 41 7 ị",
	"119 23 17 16 44 18 o",
	"134 105 16 20 40 17 ó",
	"202 39 16 20 40 17 ò",
	"133 172 17 21 39 18 ỏ",
	"134 85 16 19 41 17 õ",
	"134 126 16 20 44 17 ọ",
	"151 65 16 19 41 17 ô",
	"61 44 18 20 40 19 ố",
	"116 83 17 20 40 18 ồ",
	"152 38 16 22 38 17 ổ",
	"116 40 17 21 39 18 ỗ",
	"151 145 16 23 41 17 ộ",
	"101 22 17 17 43 18 ơ",
	"115 223 17 20 40 18 ớ",
	"115 202 17 20 40 18 ờ",
	"115 180 17 21 39 18 ở",
	"115 160 17 19 41 18 ỡ",
	"101 0 17 21 43 18 ợ",
	"151 105 16 19 44 17 y",
	"185 126 16 21 42 17 ý",
	"185 148 16 21 42 17 ỳ",
	"202 60 16 22 41 17 ỷ",
	"185 170 16 21 42 17 ỹ",
	"185 211 16 20 44 17 ỵ",
	"169 44 15 16 44 16 u",
	"185 252 16 18 42 17 ú",
	"219 129 15 18 42 16 ù",
	"234 223 15 19 41 16 ủ",
	"186 20 16 18 42 17 ũ",
	"137 0 16 20 44 17 ụ",
	"22 77 17 17 43 18 ư",
	"78 262 18 18 42 19 ứ",
	"79 107 18 18 42 19 ừ",
	"78 242 18 19 41 19 ử",
	"79 65 18 18 42 19 ữ",
	"79 147 18 21 43 19 ự",
	"151 85 16 19 41 17 b",
	"234 263 14 16 44 15 c",
	"134 65 16 19 41 17 d",
	"97 192 17 19 41 18 đ",
	"250 185 11 19 41 12 f",
	"168 83 16 20 44 17 g",
	"234 203 15 19 41 16 h",
	"264 115 8 22 41 9 j",
	"234 243 15 19 41 16 k",
	"273 184 6 19 41 7 l",
	"0 19 24 16 44 25 m",
	"219 148 15 16 44 16 n",
	"185 65 16 19 44 17 p",
	"185 232 16 19 44 17 q",
	"250 205 11 16 44 12 r",
	"205 0 13 16 44 14 s",
	"250 146 13 18 42 14 t",
	"188 0 16 16 44 17 v",
	"0 36 23 16 44 24 w",
	"98 82 17 16 44 18 x",
	"249 263 13 16 44 14 z",
	"151 253 16 19 41 17 0",
	"250 241 10 18 42 11 1",
	"219 184 15 18 42 16 2",
	"235 139 14 18 42 15 3",
	"219 165 15 18 42 16 4",
	"235 177 14 18 42 15 5",
	"219 87 15 19 41 16 6",
	"250 92 13 18 42 14 7",
	"219 0 15 19 41 16 8",
	"219 20 15 19 41 16 9",
	"263 165 8 19 41 9 !",
	"250 165 12 19 41 13 ?",
	"41 101 7 8 55 8 ,",
	"42 68 7 5 55 8 .",
	"273 115 6 15 45 7 :",
	"265 0 7 18 45 8 ;",
	"33 44 8 7 43 9 \"",
	"49 101 4 7 43 5 '",
	"219 40 15 24 39 16 $",
	"21 95 19 19 41 20 %",
	"0 95 20 19 41 21 &",
	"265 39 7 18 42 8 (",
	"265 58 7 18 42 8 )",
	"24 44 8 5 50 9 -",
	"250 130 13 15 45 14 +",
	"185 271 14 9 48 15 =",
	"219 65 15 21 41 16 /",
	"273 0 3 24 41 4 |",
	"219 107 15 21 41 16 \\",
	"115 274 15 6 50 16 ~",
	"0 72 21 22 42 22 @",
	"151 273 13 7 43 14 ^",
	"40 270 9 9 42 10 *"
};
        #endregion

        bitmapFont = new BitmapFont(textureFont, lines);
    }

    void Update()
    {
        CreatFont();
    }

    void CreatFont()
    {
        if (isUpdate)
        {
            labelFont.setSortingLayer(nameSorttingLayer);
            labelFont.setSortingOrderInLayer(sorttingOrderInLayer);
            labelFont.setAlignment(alignment);
            labelFont.createLabel(bitmapFont, value, kerning, space);
            isUpdate = false;
        }
    }
    public void Social2Read(string nameSorttingLayer, int sorttingOrderInLayer, TextAlignment Alignment,
                       string value, float kerning, float space)
    {
        this.nameSorttingLayer = nameSorttingLayer;
        this.sorttingOrderInLayer = sorttingOrderInLayer;
        this.alignment = Alignment;
        this.value = value;
        this.kerning = kerning;
        this.space = space;
        isUpdate = true;
    }
}
