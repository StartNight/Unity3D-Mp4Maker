# Unity3D-Mp4Maker

C#版的MP4视频文件信息解析,只引用基础库类,无其他库类的引用
在Unity3D下面一样可以使用

##  使用这个脚本你可以获取下面关于mp4文件的信息

如: 分辨率,时长,类型,大小,创建时间

# 解析輸出

```bash
FileTypeBox
  Size : 24
  Type : ftyp
  MajorBrand : mp42
  MinorVersion : 
  CompatibleBrands : isommp42
MediaDataBox
  Size : 2473246
  Type : mdat
  ContentLength : 2473238
FreeSpaceBox
  Size : 4520
  Type : free
  ContentLength : 4512
MovieBox
  Size : 1870
  Type : moov
MovieBox\MovieHeaderBox
  Size : 108
  Type : mvhd
  Version : 0
  Flags : 00-00-00
  CreateTime : 2019/12/17 17:13:43
  ModificationTime : 2019/12/17 17:13:43
  TimeScale : 1000
  Duration : 3772
  TimeLength : 3.772 s
  Rate : 1
  Volume : 1
  Reserved : 00-00-00-00-00-00-00-00-00-00
  Matrix : 65536,0,0,0,65536,0,0,0,1073741824
  PreDefined : 00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00
  NextTrackId : 3
MovieBox\MetaBox
  Size : 121
  Type : meta
  Version : 0
  Flags : 00-00-21
  ContentLength : 109
MovieBox\TrackBox
  Size : 1038
  Type : trak
MovieBox\TrackBox\TrackHeaderBox
  Size : 92
  Type : tkhd
  Version : 0
  Flags : 00-00-07
  CreateTime : 2019/12/17 17:13:43
  ModificationTime : 2019/12/17 17:13:43
  TrackID : 1
  Reserved : 0
  Duration : 3772
  Reserved : 0,0
  Layer : 0
  AlternateGroup : 0
  Volume : 0
  Reserved : 0
  Matrix : 65536,0,0,0,65536,0,0,0,1073741824
  Width : 640
  Height : 480
MovieBox\TrackBox\MediaBox
  Size : 938
  Type : mdia
MovieBox\TrackBox\MediaBox\MediaHeaderBox
  Size : 32
  Type : mdhd
  Version : 0
  Flags : 00-00-00
  CreateTime : 2019/12/17 17:13:43
  ModificationTime : 2019/12/17 17:13:43
  TimeScale : 90000
  Duration : 339467
  Language : 00000000 00000000
  PreDefined : 0
MovieBox\TrackBox\MediaBox\HandlerReferenceBox
  Size : 44
  Type : hdlr
  Version : 0
  Flags : 00-00-00
  PreDefined : 0
  HandlerType : vide
  Reserved : 0,0,0
  Name : VideoHandle
MovieBox\TrackBox\MediaBox\MediaInformationBox
  Size : 854
  Type : minf
MovieBox\TrackBox\MediaBox\MediaInformationBox\VideoMediaHeaderBox
  Size : 20
  Type : vmhd
  Version : 0
  Flags : 00-00-01
  GraphicsMode : 0
  OpColor : 0,0,0
MovieBox\TrackBox\MediaBox\MediaInformationBox\DataInformationBox
  Size : 36
  Type : dinf
MovieBox\TrackBox\MediaBox\MediaInformationBox\DataInformationBox\DataReferenceBox
  Size : 28
  Type : dref
  Version : 0
  Flags : 00-00-00
  EntryCount : 1
MovieBox\TrackBox\MediaBox\MediaInformationBox\DataInformationBox\DataReferenceBox\DataEntryUrlBox
  Size : 12
  Type : url
  Version : 0
  Flags : 00-00-01
  Location : 
MovieBox\TrackBox\MediaBox\MediaInformationBox\SampleTableBox
  Size : 790
  Type : stbl
MovieBox\TrackBox\MediaBox\MediaInformationBox\SampleTableBox\SampleDescriptionBox
  Size : 178
  Type : stsd
  Version : 0
  Flags : 00-00-00
  EntryCount : 1
MovieBox\TrackBox\MediaBox\MediaInformationBox\SampleTableBox\SampleDescriptionBox\SampleEntry
  Size : 162
  Type : avc1
  Reserved : 0,0,0,0,0,0
  DataReferenceIndex : 1
MovieBox\TrackBox\MediaBox\MediaInformationBox\SampleTableBox\TimeToSampleBox
  Size : 168
  Type : stts
  Version : 0
  Flags : 00-00-00
  EntryCount : 19
  SampleCount : 1,14,1,21,1,6,2,2,2,2,2,2,2,2,2,2,2,1,8
  SampleDeltas : 6493,4499,4509,4500,4490,4501,4492,4507,4492,4507,4493,4506,4493,4507,4492,4507,4492,4508,4499
MovieBox\TrackBox\MediaBox\MediaInformationBox\SampleTableBox\SampleSizeBox
  Size : 320
  Type : stsz
  Version : 0
  Flags : 00-00-00
  SampleSize : 0
  SampleCount : 75
  EntrySize : 28384,20762,32986,37220,31942,35826,35359,34416,33380,35938,32239,34326,35127,33610,36638,33771,35001,32392,29924,68881,39600,36986,34851,42119,30216,33564,27977,26736,29889,29433,31844,27765,27300,21469,28343,25686,29222,27196,68539,42875,38770,32598,36496,31465,34818,33051,27156,28712,25484,28587,27679,29602,31300,24207,24289,25392,26633,60898,40983,41188,34165,33186,32904,36045,31128,30491,34074,30812,26314,25990,28260,27787,30652,33405,23297
MovieBox\TrackBox\MediaBox\MediaInformationBox\SampleTableBox\SampleToChunkBox
  Size : 52
  Type : stsc
  Version : 0
  Flags : 00-00-00
  EntrySize : 3
  FirstChunks : 1,2,4
  SamplesPerChunks : 23,21,10
  SmapleDescriptionIndexs : 1,1,1
MovieBox\TrackBox\MediaBox\MediaInformationBox\SampleTableBox\SyncSampleBox
  Size : 32
  Type : stss
  Version : 0
  Flags : 00-00-00
  EntrySize : 4
  SampleNumbers : 1,20,39,58
MovieBox\TrackBox\MediaBox\MediaInformationBox\SampleTableBox\ChunkOffsetBox
  Size : 32
  Type : stco
  Version : 0
  Flags : 00-00-00
  EntrySize : 4
  ChunkOffset : 6422,818110,1509107,2188005
MovieBox\TrackBox
  Size : 595
  Type : trak
MovieBox\TrackBox\TrackHeaderBox
  Size : 92
  Type : tkhd
  Version : 0
  Flags : 00-00-07
  CreateTime : 2019/12/17 17:13:43
  ModificationTime : 2019/12/17 17:13:43
  TrackID : 2
  Reserved : 0
  Duration : 3712
  Reserved : 0,0
  Layer : 0
  AlternateGroup : 0
  Volume : 1
  Reserved : 0
  Matrix : 65536,0,0,0,65536,0,0,0,1073741824
  Width : 0
  Height : 0
MovieBox\TrackBox\MediaBox
  Size : 495
  Type : mdia
MovieBox\TrackBox\MediaBox\MediaHeaderBox
  Size : 32
  Type : mdhd
  Version : 0
  Flags : 00-00-00
  CreateTime : 2019/12/17 17:13:43
  ModificationTime : 2019/12/17 17:13:43
  TimeScale : 8000
  Duration : 29696
  Language : 00000000 00000000
  PreDefined : 0
MovieBox\TrackBox\MediaBox\HandlerReferenceBox
  Size : 44
  Type : hdlr
  Version : 0
  Flags : 00-00-00
  PreDefined : 0
  HandlerType : soun
  Reserved : 0,0,0
  Name : SoundHandle
MovieBox\TrackBox\MediaBox\MediaInformationBox
  Size : 411
  Type : minf
MovieBox\TrackBox\MediaBox\MediaInformationBox\SoundMediaHeaderBox
  Size : 16
  Type : smhd
  Version : 0
  Flags : 00-00-00
  Balance : 0
  Reserved : 0
MovieBox\TrackBox\MediaBox\MediaInformationBox\DataInformationBox
  Size : 36
  Type : dinf
MovieBox\TrackBox\MediaBox\MediaInformationBox\DataInformationBox\DataReferenceBox
  Size : 28
  Type : dref
  Version : 0
  Flags : 00-00-00
  EntryCount : 1
MovieBox\TrackBox\MediaBox\MediaInformationBox\DataInformationBox\DataReferenceBox\DataEntryUrlBox
  Size : 12
  Type : url
  Version : 0
  Flags : 00-00-01
  Location : 
MovieBox\TrackBox\MediaBox\MediaInformationBox\SampleTableBox
  Size : 351
  Type : stbl
MovieBox\TrackBox\MediaBox\MediaInformationBox\SampleTableBox\SampleDescriptionBox
  Size : 91
  Type : stsd
  Version : 0
  Flags : 00-00-00
  EntryCount : 1
MovieBox\TrackBox\MediaBox\MediaInformationBox\SampleTableBox\SampleDescriptionBox\SampleEntry
  Size : 75
  Type : mp4a
  Reserved : 0,0,0,0,0,0
  DataReferenceIndex : 1
MovieBox\TrackBox\MediaBox\MediaInformationBox\SampleTableBox\TimeToSampleBox
  Size : 32
  Type : stts
  Version : 0
  Flags : 00-00-00
  EntryCount : 2
  SampleCount : 1,28
  SampleDeltas : 1024,1024
MovieBox\TrackBox\MediaBox\MediaInformationBox\SampleTableBox\SampleSizeBox
  Size : 136
  Type : stsz
  Version : 0
  Flags : 00-00-00
  SampleSize : 0
  SampleCount : 29
  EntrySize : 195,225,272,239,229,207,209,199,168,186,169,207,181,181,169,186,187,215,187,197,196,178,178,172,192,191,198,191,184
MovieBox\TrackBox\MediaBox\MediaInformationBox\SampleTableBox\SampleToChunkBox
  Size : 52
  Type : stsc
  Version : 0
  Flags : 00-00-00
  EntrySize : 3
  FirstChunks : 1,2,4
  SamplesPerChunks : 10,8,3
  SmapleDescriptionIndexs : 1,1,1
MovieBox\TrackBox\MediaBox\MediaInformationBox\SampleTableBox\ChunkOffsetBox
  Size : 32
  Type : stco
  Version : 0
  Flags : 00-00-00
  EntrySize : 4
  ChunkOffset : 815981,1507612,2186514,2479087
```



# ISO/IEC 14496

ISO/IEC 14496 是MPEG專家組制定的MPEG-4標準，於2000年年初正式成爲國際標準。MPEG-4與MPEG-1和MPEG-2有很大的不同。MPEG-4不只是具體壓縮算法，它是針對數字電視、交互式繪圖應用（影音合成內容）、交互式多媒體（WWW、資料擷取與分散）等整合及壓縮技術的需求而制定的國際標準。

MPEG-4由一系列的字標準組成，包含以下的部分：

- ISO/IEC 14496-1：**系統** - 描述視頻和音頻數據流的控制、同步以及混合方式（即混流Multiplexing，簡寫爲MUX）。
- ISO/IEC 14496-2：**視頻** - 定義一個對各種視覺信息（包括自然視頻、靜止紋理、計算機合成圖形等等）的編解碼器。例如，XviD編碼就屬於MPEG -4 Part 2。
- ISO/IEC 14496-3：**音頻** - 定義一個對各種音頻信號進行編碼的編解碼器的集合，包括高級音頻編碼（Advanced Audio Coding，縮寫爲AAC）的若干變形和其他一些音頻/語音編碼工具。
- ISO/IEC 14496-4：**一致性** - 定義對本標準其他的部分進行一致性測試的程序。
- ISO/IEC 14496-5：**參考軟件** - 提供用於演示功能和說明本標準其他部分功能的軟件。
- ISO/IEC 14496-6：**多媒體傳輸集成框架** - DMIF for Delivery Multimedia Integration Framework。
- ISO/IEC 14496-7：**優化的參考軟件** - 提供對實現（ISO/IEC 14496-5）進行優化的例子。
- ISO/IEC 14496-8：**在IP網絡上傳輸** - 定義在IP網絡上傳輸MPEG-4內容的方式。
- ISO/IEC 14496-9：**參考硬件** - 提供用於演示怎樣在硬件上實現本標準其他部分功能的硬件設計方案。
- ISO/IEC 14496-10：**高級視頻編碼** - Advanced Video Coding，縮寫爲AVC，定義一個視頻編解碼器codec。AVC和XviD都屬於MPEG-4編碼，但由於AVC屬於MPEG-4 Part 10，在技術特性上比屬於MPEG-4 Part 2的XviD要先進。另外，它和ITU-T H.264標準是一致的，故又稱爲H.264。
- ISO/IEC 14496-11：**場景描述和應用引擎** - 被稱作 BIFS（Binary Format for Scene），XMT，MPEG-J。它被設計的用處是實現動態顯示和交互顯示的有效展現，構建2D和3D的圖像、畫面、文本，以及試聽材料。這種顯示的展現包括對不同場景組件（scene component）的時空組織性，以及用戶交互性和動畫進行描述。
- ISO/IEC 14496-12：**基於ISO的媒體文件格式** - 定義一個存儲媒體內容的文件格式。**mp4文件的解析參考的就是該部分**。
- ISO/IEC 14496-13：**知識產權管理和保護拓展** - IPMP for Intellectual Property Management and Protection。
- ISO/IEC 14496-14：**MPEG-4文件格式** - 定義基於 ISO/IEC 14496-12 的用於存儲MPEG-4內容的視頻文件格式。
- ISO/IEC 14496-15：**AVC文件格式** - 定義基於 ISO/IEC 14496-12 的用於存儲 ISO/IEC 14496-10 的視頻內容的文件格式。
- ISO/IEC 14496-16：**動畫擴展框架** - AFX，Animation Framework eXtension。
- ISO/IEC 14496-17：**同步文本字幕格式**。
- ISO/IEC 14496-18：**字體壓縮和流式傳輸** - 針對開放字體格式Open Font Format。
- ISO/IEC 14496-19：**合成材質流** - Synthesized Texture Strean。
- ISO/IEC 14496-20：**簡單場景表示** - LASeR for Lightweight Scene Representation。
- ISO/IEC 14496-21：**用於描繪（Rendering）的MPEG-J拓展**。
- ISO/IEC 14496-22：**開放字體格式** - Open Font Format。
- ISO/IEC 14496-23：**符號化音樂表示** - Symbolic Music Representation。
- ISO/IEC 14496-24：**音頻與系統交互作用** - Audio and systems interaction。
- ISO/IEC 14496-25：**3D圖形壓縮模型** - 3D Graphics Compression Model。
- ISO/IEC 14496-26：**音頻一致性檢查** - 定義測試音頻數據與 ISO/IEC 14496-3 是否一致的方法，Audio comformance。
- ISO/IEC 14496-27：**3D圖形一致性檢查** - 定義測試3D圖形數據與 ISO/IEC 14496-11:2005，ISO/IEC 14496-16:2006，ISO/IEC 14496-21:2006 和 ISO/IEC 14496-25:2009 是否一致的方法，3D Graphics conformance。
- ISO/IEC 14496-28：**複合字體表示法** - Composite font representation。
- ISO/IEC 14496-29：**網絡視頻編碼** - Web video coding。
- ISO/IEC 14496-30：**ISO基本媒體文件格式中的定時文本和其他可視覆蓋層** - Timed text and other visual overlays in ISO base media file format。
- ISO/IEC 14496-31：**瀏覽器視頻編碼** - Video coding for browsers。
- ISO/IEC 14496-33：**互聯網視頻編碼** - Internet video coding。

------

# mp4文件格式

MP4是在 ISO/IEC 14496-14 標準文件中定義的一種多媒體容器格式，是 ISO/IEC 14496-12 標準中所定義的媒體格式的一種實現。

## 參考標準

- [ISO/IEC 14496-12](https://download.csdn.net/download/zgfpig/10187905)
- [ISO/IEC 14496-14](https://download.csdn.net/download/michaelkuo8088/512153)

## 術語和定義

- box：由唯一類型標識符和長度定義的面向對象構建塊。
- container box：用於包含和分組一組相關box的box。
- sample：一個時間戳的所有數據。一個音軌中的sample的時間戳不能重複。在非hint track中，一個sample是一個單獨的視頻幀，或一組連續的視頻幀，或是一段連續的壓縮音頻；在hint track中，一個sample定義一個或多個流數據包的形成。
- chunk：一個音軌的連續sample集合。
- track：相關sample的時序。對於media data，track對應於一系列圖像或採樣的音頻；對於hint track，一個軌道對應於一個流信道。
- hint track：一種特殊的音軌，它不包含媒體數據，而是包含將一個或多個音軌打包成一個流媒體信道的方法。
- presentation：一個或多個運動序列，可能與音頻結合。表示一個視頻文件。
- media data box：爲一個presentation保存實際媒體數據的box，類型標識符爲mdat。
- movie box：一個container box，其子box定義了一個presentation的metadata，類型標識符爲moov。
- sample description：定義並描述一個track中多個sample格式的box，類型標識符爲stsd。
- sample table：一個track中sample的時序和物理佈局，類型標識符爲stbl。
- sync sample：描述關鍵幀，類型標識符爲stss。

## 文件組成

MP4文件由一系列的box構成，box中可以套box，所有的數據都保存在box中。每個文件主要由以下部分構成：

- File Type Box：ftyp，文件類型
- Media Data Box：mdat，實際媒體數據
- Free Space Box：free或skip，無關緊要的內容，可忽略
- Meta Box：meta，包含描述或註釋信息
- Movie Box：moov，實際媒體數據的metadata
  - Movie Header Box：mvhd，文件總體信息，如時長和創建時間等
  - Track Box：trak，一個視頻或音頻序列
    - Track Header Box：tkhd，track的特性和總體信息，如時長和寬高等
    - Media Box：mdia，包含整個track的媒體信息，比如媒體類型和sample信息
      - Media Header Box：mdhd，包含track總體信息，內容和track header大致一樣
      - Handler Reference Box：hdlr，解釋媒體的播放過程信息
      - Media Information Box：minf，包含所有描述該track的媒體信息的對象，信息存儲在子box中
        - Video Media Header Box / Sound Media Header Box：vmhd/smhd，包含當前track的視頻/音頻描述信息
        - Data Infomation Box：dinf，解釋如何定位媒體信息
          - Data Reference Box：dref，用來設置當前box描述信息的data entry
            - Data Entry Url Box：url，用來定位track數據
            - Data Entry Urn Box：urn，用來定位track數據
        - Sample Table Box：stbl，sample時序和物理佈局表
          - Sample Description Box：stsd，定義和描述軌中的採樣格式結構
          - Time To Sample Box：stts，存儲sample的duration，描述sample時序的映射方法
          - Sync Sample Box：stss，確定media中的關鍵幀
          - Sample Size Box：stsz或stz2，定義每個sample的大小
          - Sample To Chunk Box：stsc，描述sample與chunk的映射關係
          - Chunk Offset Box：stco（32位）或co64（64位），定義每個chunk在媒體流中的位置
          - Composition Time To Sample Box：ctts，解碼時間和合成時間的偏移量

------

# C#實現

本文使用c#解析MP4文件，後面將展示部分box的結構，逐步補充。

## Mp4File

```csharp
    public class Mp4File
    {
        private string filePath;
        private string fileName;

        /// <summary>
        /// File Type
        /// </summary>
        public FileTypeBox Ftyp = new FileTypeBox();

        /// <summary>
        /// Media Data
        /// </summary>
        public List<MediaDataBox> Mdats = new List<MediaDataBox>();

        /// <summary>
        /// Movie
        /// </summary>
        public MovieBox Moov = new MovieBox();

        /// <summary>
        /// Free
        /// </summary>
        public FreeSpaceBox Free;

        /// <summary>
        /// Meta
        /// </summary>
        public MetaBox Meta;

        /// <summary>
        /// 其他
        /// </summary>
        public List<Box> Boxs = new List<Box>();

        public bool Open(string file)
        {
            this.filePath = file;
            this.fileName = Path.GetFileNameWithoutExtension(fileName);

            FileStream fs = new FileStream(this.filePath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            br.BaseStream.Seek(0, SeekOrigin.Begin);
            while (br.PeekChar() > -1)
            {
                Box box = new Box();
                box.ReadHeader(br);
                switch (box.Type)
                {
                    case "ftyp":
                        Ftyp.Copy(box);
                        Ftyp.ReadContent(br);
                        break;
                    case "mdat":
                        MediaDataBox mdat = new MediaDataBox();
                        mdat.Copy(box);
                        mdat.ReadContent(br);
                        Mdats.Add(mdat);
                        break;
                    case "free":
                    case "skip":
                        Free = new FreeSpaceBox();
                        Free.Copy(box);
                        Free.ReadContent(br);
                        break;
                    case "meta":
                        Meta = new MetaBox();
                        Meta.Copy(box);
                        Meta.ReadFullHeader(br);
                        Meta.ReadContent(br);
                        break;
                    case "moov":
                        Moov.Copy(box);
                        Moov.ReadContent(br);
                        break;
                    default:
                        box.ReadContent(br);
                        Boxs.Add(box);
                        break;
                }
            }

            br.Close();
            fs.Close();

            return true;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(Ftyp.ToString());
            for (int i = 0; i < Mdats.Count; i++)
            {
                str.Append(Mdats[i].ToString());
            }
            if (Free != null)
            {
                str.Append(Free.ToString());
            }
            if (Meta != null)
            {
                str.Append(Meta.ToString());
            }
            str.Append(Moov.ToString());

            // 其他
            for (int i = 0; i < Boxs.Count; i++)
            {
                str.Append(Boxs[i].ToString());
            }
            return str.ToString();
        }
    }
```

## Box

box以box header開頭，header中包含box的大小和類型。box中的字節序爲網絡字節序，也就是大端字節序（Big-Endian）.

```csharp
    /// <summary>
    /// 由唯一類型標識符和長度定義的面向對象的構建；
    /// box中的字節序爲網絡字節序，也就是大端字節序（Big-Endian）;
    /// </summary>
    public class Box
    {
        /// <summary>
        /// box前四個字節，uint32類型，標識整個box所佔用的大小，包括header部分；
        /// 如果box很大（例如存放具體視頻數據的mdat box），超過了uint32的最大數值，size就被設置爲1，並用type後面的8位uint64的largesize來存放大小；
        /// </summary>
        public ulong Size;

        /// <summary>
        /// box類型，uint類型，佔四個字節
        /// </summary>
        public string Type;

        /// <summary>
        /// 若Type爲uuid，則header中包含該字段，類型爲unsigned int(8)[16]，佔16個字節
        /// </summary>
        public string UserType;

        /// <summary>
        /// box header長度
        /// </summary>
        protected int headerLength;

        /// <summary>
        /// 設置父級路徑
        /// </summary>
        protected string parentPath = string.Empty;
        
        /// <summary>
        /// 設置父級路徑
        /// </summary>
        /// <returns></returns>
        public string SetParentPath(string value)
        {
            return parentPath = value;
        }

        /// <summary>
        /// 獲取路徑
        /// </summary>
        /// <returns></returns>
        public string GetPath()
        {
            return Path.Combine(parentPath, this.GetType().Name);
        }

        /// <summary>
        /// 讀取box header，獲取大小和類型
        /// </summary>
        /// <param name="br"></param>
        /// <returns>box header的長度</returns>
        public virtual void ReadHeader(BinaryReader br)
        {
            Size = GetUint32(br);
            Type = GetString(br, 4).Trim();
            if (Size == 1)
            {
                Size = GetUint64(br);
                headerLength = 16;
            }
            else
            {
                headerLength = 8;
            }
            if (Type.Equals("uuid"))
            {
                UserType = GetString(br, 16).Trim();
                headerLength += 16;
            }
        }

        /// <summary>
        /// 根據長度跳過box內容
        /// </summary>
        /// <param name="br"></param>
        public virtual void ReadContent(BinaryReader br)
        {
            ulong contentLength = Size - (ulong)headerLength;
            ulong i = 0;
            while (i < contentLength)
            {
                try
                {
                    br.ReadByte();
                }
                catch (Exception e)
                {
                    break;
                }
                i++;
            }
        }
        
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine(GetPath());
            if (Size > uint.MaxValue)
            {
                str.AppendLine("  Size : " + 1);
                str.AppendLine("  Type : " + Type);
                str.AppendLine("  Largesize : " + Size);
            }
            else
            {
                str.AppendLine("  Size : " + Size);
                str.AppendLine("  Type : " + Type);
            }
            //str.AppendLine("  ContentLength : " + (Size - (ulong)headerLength));

            return str.ToString();
        }

        public virtual void Copy(Box box)
        {
            Size = box.Size;
            Type = box.Type;
            UserType = box.UserType;
            headerLength = box.headerLength;
            parentPath = box.parentPath;
        }

        public static short GetInt16(BinaryReader br)
        {
            byte[] bytes = br.ReadBytes(2);
            Array.Reverse(bytes);
            return BitConverter.ToInt16(bytes, 0);
        }

        public static ushort GetUint16(BinaryReader br)
        {
            byte[] bytes = br.ReadBytes(2);
            Array.Reverse(bytes);
            return BitConverter.ToUInt16(bytes, 0);
        }

        public static int GetInt32(BinaryReader br)
        {
            byte[] bytes = br.ReadBytes(4);
            Array.Reverse(bytes);
            return BitConverter.ToInt32(bytes, 0);
        }

        public static uint GetUint32(BinaryReader br)
        {
            byte[] bytes = br.ReadBytes(4);
            Array.Reverse(bytes);
            return BitConverter.ToUInt32(bytes, 0);
        }

        public static ulong GetUint64(BinaryReader br)
        {
            byte[] bytes = br.ReadBytes(8);
            Array.Reverse(bytes);
            return BitConverter.ToUInt64(bytes, 0);
        }

        public static int[] GetInt32Array(BinaryReader br, int length)
        {
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = GetInt32(br);
            }
            return array;
        }

        public static uint[] GetUint32Array(BinaryReader br, int length)
        {
            uint[] array = new uint[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = GetUint32(br);
            }
            return array;
        }

        public static ushort[] GetUint16Array(BinaryReader br, int length)
        {
            ushort[] array = new ushort[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = GetUint16(br);
            }
            return array;
        }

        public static string GetString(BinaryReader br, int length)
        {
            byte[] bytes = br.ReadBytes(length);
            return Encoding.ASCII.GetString(bytes).Trim('\0');
        }

        public static byte GetByte(BitArray bitArray, int startIndex, int length)
        {
            byte data = 0;
            for (int i = 0; i < length; i++)
            {
                if (bitArray[startIndex + i])
                {
                    data |= (byte)(1 << 8 - (startIndex + i));
                }
            }
            return data;
        }
    }
```

## Full Box

full box的header中除了size、type外，還包含version和flags字段。

```csharp
    /// <summary>
    /// box header相對box多了version和flags字段
    /// </summary>
    public class FullBox : Box
    {
        /// <summary>
        /// 用來指定該box的文件的格式
        /// full box的特有字段
        /// </summary>
        public byte Version;

        /// <summary>
        /// 標誌圖
        /// full box的特有字段
        /// </summary>
        public byte[] Flags = new byte[3];

        public override void ReadHeader(BinaryReader br)
        {
            base.ReadHeader(br);
            ReadFullHeader(br);
        }

        /// <summary>
        /// 讀取fullbox相對box額外的信息
        /// </summary>
        /// <param name="br"></param>
        public void ReadFullHeader(BinaryReader br)
        {
            Version = br.ReadByte();
            Flags = br.ReadBytes(3);
            headerLength += 4;
        }
        
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(base.ToString());
            str.AppendLine("  Version : " + Version);
            str.AppendLine("  Flags : " + BitConverter.ToString(Flags));
            return str.ToString();
        }

        public virtual void Copy(FullBox box)
        {
            base.Copy(box);
            Version = box.Version;
            Flags = box.Flags;
        }
    }
```

## File Type Box

文件類型，包含在文件中，有且僅有一個。

```csharp
    /// <summary>
    /// 文件類型，佔24個字節，type域爲ftyp
    /// </summary>
    public class FileTypeBox : Box
    {
        /// <summary>
        /// 文件類型標識符，例如mp42，佔四個字節（int）
        /// </summary>
        public string MajorBrand;

        /// <summary>
        /// major brand的次版本標識，佔四個字節（int）
        /// </summary>
        public string MinorVersion;

        /// <summary>
        /// 兼容類型，佔八個字節
        /// </summary>
        public string CompatibleBrands;

        public override void ReadContent(BinaryReader br)
        {
            MajorBrand = GetString(br, 4);
            MinorVersion = GetString(br, 4);
            CompatibleBrands = GetString(br, 8);
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(base.ToString());

            str.AppendLine("  MajorBrand : " + MajorBrand);
            str.AppendLine("  MinorVersion : " + MinorVersion);
            str.AppendLine("  CompatibleBrands : " + CompatibleBrands);

            return str.ToString();
        }
    }
```

## Media Data Box

在視頻track中，包含多個視頻幀。一個文件可能包含0個或多個Medai Data Box。實際媒體數據緊跟在type字段後。

```csharp
    /// <summary>
    /// 用來容納實體數據的box，type域爲mdat；
    /// 該box包含於文件層，可以有多個，也可以沒有（當媒體數據全部爲外部文件引用時），用來存儲媒體數據。
    /// 數據直接跟在box type字段後面，它的結構是由metadata來描述的，metadata通過文件中的絕對偏移來引用媒體數據。
    /// </summary>
    public class MediaDataBox : Box
    {
        /// <summary>
        /// 實體數據
        /// </summary>
        public byte[] Datas;

        public override void ReadContent(BinaryReader br)
        {
            ulong contentLength = Size - (ulong)headerLength;
            Datas = new byte[contentLength];
            ulong i = 0;
            while (i < contentLength)
            {
                try
                {
                    Datas[i] = br.ReadByte();
                }
                catch (Exception e)
                {
                    break;
                }
                i++;
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(base.ToString());
            str.AppendLine("  ContentLength : " + Datas.LongLength);

            return str.ToString();
        }
    }
```

## Free Space Box

0個或多個，可包含在文件或其他box中。

```csharp
    /// <summary>
    /// free space box中的內容是無關緊要的，可以被忽略。
    /// 該box被刪除後，不會對播放產生任何影響，它的type域可以是free或skip
    /// </summary>
    public class FreeSpaceBox : Box
    {
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(base.ToString());
            str.AppendLine("  ContentLength : " + (Size - (ulong)headerLength));
            return str.ToString();
        }
    }
```

## Meta Box

可包含在文件中，也可包含在Movie Box、Track Box、Additional Metadata Container Box、Movie Fragment Box、Track Fragment Box。在文件、Movie Box、Track Box中有0個或1個，在Additional Metadata Container Box中有一個或多個。

```csharp
    /// <summary>
    /// type域爲meta，包含描述或註釋信息
    /// </summary>
    public class MetaBox : FullBox
    {
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(base.ToString());
            str.AppendLine("  ContentLength : " + (Size - (ulong)headerLength));
            return str.ToString();
        }
    }
```

## Movie Box

包含在文件中，有且僅有一個。包含多個box。

```csharp
    /// <summary>
    /// 該box用來存放媒體的metadata信息，其內容信息由子box詮釋，type域爲moov；
    /// 該box有且只有一個並且包含在文件層，一般情況下moov box會緊隨ftyp box出現，但也有放在文件末尾的。
    /// </summary>
    public class MovieBox : Box
    {
        /// <summary>
        /// 用來存放文件的總體信息，如時長和創建時間等，它是獨立於媒體的並且與整個播放相關
        /// </summary>
        public MovieHeaderBox MovieHeader = new MovieHeaderBox();

        /// <summary>
        /// 註釋或描述信息
        /// </summary>
        public MetaBox Meta = null;

        /// <summary>
        /// track box序列
        /// </summary>
        public List<TrackBox> Tracks = new List<TrackBox>();

        /// <summary>
        /// 其他
        /// </summary>
        public List<Box> Boxs = new List<Box>();

        public override void ReadContent(BinaryReader br)
        {
            ulong i = (ulong)headerLength;
            while (i < Size)
            {
                Box box = new Box();
                box.SetParentPath(GetPath());
                box.ReadHeader(br);
                switch (box.Type)
                {
                    case "mvhd":
                        MovieHeader.Copy(box);
                        MovieHeader.ReadFullHeader(br);
                        MovieHeader.ReadContent(br);
                        break;
                    case "meta":
                        Meta = new MetaBox();
                        Meta.Copy(box);
                        Meta.ReadFullHeader(br);
                        Meta.ReadContent(br);
                        break;
                    case "trak":
                        TrackBox track = new TrackBox();
                        track.Copy(box);
                        track.ReadContent(br);
                        Tracks.Add(track);
                        break;
                    default:
                        box.ReadContent(br);
                        Boxs.Add(box);
                        break;
                }
                i += box.Size;
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(base.ToString());

            str.Append(MovieHeader.ToString());
            if (Meta != null)
            {
                str.Append(Meta.ToString());
            }

            for (int i = 0; i < Tracks.Count; i++)
            {
                str.Append(Tracks[i].ToString());
            }

            for (int i = 0; i < Boxs.Count; i++)
            {
                str.Append(Boxs[i].ToString());
            }

            return str.ToString();
        }
    }
```

## Movie Header Box

包含在Movie Box中，有且僅有一個。

```csharp
    /// <summary>
    /// 用來存放文件的總體信息，如時長和創建時間等，它是獨立於媒體的並且與整個播放相關，type域爲mvhd；
    /// </summary>
    public class MovieHeaderBox : FullBox
    {
        /// <summary>
        /// 創建時間，表示相對於UTC時間1904-01-01零點的秒數；
        /// 若fullbox中的version爲0佔四個字節，若version爲1佔8個字節；
        /// </summary>
        public DateTime CreateTime;

        /// <summary>
        /// 最後修改時間，表示相對於UTC時間1904-01-01零點的秒數；
        /// 若fullbox中的version爲0佔四個字節，若version爲1佔8個字節；
        /// </summary>
        public DateTime ModificationTime;

        /// <summary>
        /// 文件媒體在1秒時間內的刻度值，即1秒長度的時間單元數，佔四個字節
        /// </summary>
        public uint TimeScale;

        /// <summary>
        /// 該track的時間長度；
        /// 若fullbox中的version爲0佔四個字節，若version爲1佔8個字節；
        /// 用duration和time scale可以計算track時長；
        /// 比如audio track的time scale = 8000, duration = 560128，時長爲70.016秒；
        ///     video track的time scale = 600, duration = 42000，時長爲70秒；
        /// </summary>
        public ulong Duration;

        /// <summary>
        /// 視頻時長（秒）=Duration/TimeScale，不佔字節，是計算出來的
        /// </summary>
        public float TimeLength;

        /// <summary>
        /// 推薦播放速率，佔四個字節；
        /// 高16位和低16位分別爲小數點整數部分和小數部分；
        /// 該值爲1.0（0x00010000）表示正常前向播放
        /// </summary>
        public float Rate;

        /// <summary>
        /// 推薦音量，佔兩個字節；
        /// 高8位和低8位分別爲小數點整數部分和小數部分；
        /// 1.0（0x0100）表示最大音量
        /// </summary>
        public float Volume;

        /// <summary>
        /// 保留字節，佔10個字節：bit(16)+int(32)[2]
        /// </summary>
        public byte[] Reserved;

        /// <summary>
        /// 視頻變換矩陣，3*3，佔36個字節
        /// </summary>
        public int[] Matrix;

        /// <summary>
        /// 預定義，佔24個字節：bit(32)[6]
        /// </summary>
        public byte[] PreDefined;

        /// <summary>
        /// 下一個track使用的id號，佔4個字節
        /// </summary>
        public uint NextTrackId;

        public override void ReadContent(BinaryReader br)
        {
            if (Version == 1)
            {
                ulong seconds = GetUint64(br);
                CreateTime = new DateTime(1904, 1, 1).AddSeconds(seconds);
                seconds = GetUint64(br);
                ModificationTime = new DateTime(1904, 1, 1).AddSeconds(seconds);
                TimeScale = GetUint32(br);
                Duration = GetUint64(br);
            }
            else
            {
                uint seconds = GetUint32(br);
                CreateTime = new DateTime(1904, 1, 1).AddSeconds(seconds).ToLocalTime();
                seconds = GetUint32(br);
                ModificationTime = new DateTime(1904, 1, 1).AddSeconds(seconds).ToLocalTime();
                TimeScale = GetUint32(br);
                Duration = GetUint32(br);
            }
            TimeLength = (float)Duration / TimeScale;

            Rate = GetUint16(br) + GetUint16(br) / 100.0f;
            Volume = br.ReadByte() + br.ReadByte() / 10.0f;
            Reserved = br.ReadBytes(10);
            Matrix = GetInt32Array(br, 9);
            PreDefined = br.ReadBytes(24);
            NextTrackId = GetUint32(br);
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(base.ToString());

            str.AppendLine("  CreateTime : " + CreateTime.ToString());
            str.AppendLine("  ModificationTime : " + ModificationTime.ToString());
            str.AppendLine("  TimeScale : " + TimeScale);
            str.AppendLine("  Duration : " + Duration);
            str.AppendLine("  TimeLength : " + TimeLength + " s");
            str.AppendLine("  Rate : " + Rate);
            str.AppendLine("  Volume : " + Volume);
            str.AppendLine("  Reserved : " + BitConverter.ToString(Reserved));
            str.AppendLine("  Matrix : " + string.Join(",", Matrix));
            str.AppendLine("  PreDefined : " + BitConverter.ToString(PreDefined));
            str.AppendLine("  NextTrackId : " + NextTrackId);

            return str.ToString();
        }
    }
```

## Track Box

包含在Movie Box中，有一個或多個。

```csharp
    /// <summary>
    /// 按時間排序的相關的採樣，對於媒體數據來說，track表示一個視頻或音頻序列，type域爲trak；
    /// tack box是一個container box，其子box包含了該track的媒體數據引用和描述（hint track除外）。
    /// 一個MP4文件中的媒體可以包含多個track，且至少有一個track，這些track之間彼此獨立，有自己的時間和空間信息。
    /// trak box必須包含一個tkhd box和一個mdia box
    /// </summary>
    public class TrackBox : Box
    {
        /// <summary>
        /// 該track的特性和總體信息，如時長、寬高等
        /// </summary>
        public TrackHeaderBox TrackHeader = new TrackHeaderBox();

        /// <summary>
        /// 註釋或描述信息
        /// </summary>
        public MetaBox Meta = null;

        /// <summary>
        /// 
        /// </summary>
        public MediaBox Media = new MediaBox();

        /// <summary>
        /// 其他
        /// </summary>
        public List<Box> Boxs = new List<Box>();

        public override void ReadContent(BinaryReader br)
        {
            ulong i = (ulong)headerLength;
            while (i < Size)
            {
                Box box = new Box();
                box.SetParentPath(GetPath());
                box.ReadHeader(br);
                switch (box.Type)
                {
                    case "tkhd":
                        TrackHeader.Copy(box);
                        TrackHeader.ReadFullHeader(br);
                        TrackHeader.ReadContent(br);
                        break;
                    case "meta":
                        Meta = new MetaBox();
                        Meta.Copy(box);
                        Meta.ReadFullHeader(br);
                        Meta.ReadContent(br);
                        break;
                    case "mdia":
                        Media.Copy(box);
                        Media.ReadContent(br);
                        break;
                    default:
                        box.ReadContent(br);
                        Boxs.Add(box);
                        break;
                }                
                i += box.Size;
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(base.ToString());

            str.Append(TrackHeader.ToString());
            if (Meta != null)
            {
                str.Append(Meta.ToString());
            }
            str.Append(Media.ToString());

            for (int i = 0; i < Boxs.Count; i++)
            {
                str.Append(Boxs[i].ToString());
            }

            return str.ToString();
        }
    }
```

## Track Header Box

包含在Track Box中，有且僅有一個。

```csharp
    /// <summary>
    /// 該track的特性和總體信息，如時長、寬高等，type域爲tkhd；
    /// </summary>
    public class TrackHeaderBox : FullBox
    {
        /// <summary>
        /// 創建時間，表示相對於UTC時間1904-01-01零點的秒數；
        /// 若fullbox中的version爲0佔四個字節，若version爲1佔8個字節；
        /// </summary>
        public DateTime CreateTime;

        /// <summary>
        /// 最後修改時間，表示相對於UTC時間1904-01-01零點的秒數；
        /// 若fullbox中的version爲0佔四個字節，若version爲1佔8個字節；
        /// </summary>
        public DateTime ModificationTime;

        /// <summary>
        /// track的id號，不能重複且不能爲0，佔四個字節
        /// </summary>
        public uint TrackID;

        /// <summary>
        /// 保留位，佔四個字節
        /// </summary>
        public uint Reserved1;

        /// <summary>
        /// 該track的時長；
        /// 若fullbox中的version爲0佔四個字節，若version爲1佔8個字節；
        /// </summary>
        public ulong Duration;

        /// <summary>
        /// 保留位，佔8個字節
        /// </summary>
        public uint[] Reserved2;

        /// <summary>
        /// 指定視頻層，默認爲0，值小的在上層，佔兩個字節；
        /// </summary>
        public short Layer;

        /// <summary>
        /// 指定track分組信息，默認爲0表示該track未與其他track有羣組關係，佔兩個字節；
        /// </summary>
        public short AlternateGroup;

        /// <summary>
        /// 音量，佔兩個字節；
        /// 高8位和低8位分別爲小數點整數部分和小數部分；
        /// 如果爲音頻track，1.0（0x0100）表示最大音量；否則爲0；
        /// </summary>
        public float Volume;

        /// <summary>
        /// 保留位，佔兩個字節
        /// </summary>
        public ushort Reserved3;

        /// <summary>
        /// 視頻變換矩陣，3*3，佔36個字節
        /// </summary>
        public int[] Matrix;

        /// <summary>
        /// 寬，與sample描述中的實際畫面大小比值，用於播放時的展示寬高，佔四個字節；
        /// 高16位和低16位分別爲小數點整數部分和小數部分；
        /// </summary>
        public float Width;

        /// <summary>
        /// 高，與sample描述中的實際畫面大小比值，用於播放時的展示寬高，佔四個字節；
        /// 高16位和低16位分別爲小數點整數部分和小數部分；
        /// </summary>
        public float Height;

        public override void ReadContent(BinaryReader br)
        {
            if (Version == 1)
            {
                ulong seconds = GetUint64(br);
                CreateTime = new DateTime(1904, 1, 1).AddSeconds(seconds);
                seconds = GetUint64(br);
                ModificationTime = new DateTime(1904, 1, 1).AddSeconds(seconds);
                TrackID = GetUint32(br);
                Reserved1 = GetUint32(br);
                Duration = GetUint64(br);
            }
            else
            {
                uint seconds = GetUint32(br);
                CreateTime = new DateTime(1904, 1, 1).AddSeconds(seconds).ToLocalTime();
                seconds = GetUint32(br);
                ModificationTime = new DateTime(1904, 1, 1).AddSeconds(seconds).ToLocalTime();
                TrackID = GetUint32(br);
                Reserved1 = GetUint32(br);
                Duration = GetUint32(br);
            }
            Reserved2 = GetUint32Array(br, 2);
            Layer = GetInt16(br);
            AlternateGroup = GetInt16(br);
            Volume = br.ReadByte() + br.ReadByte() / 10.0f;
            Reserved3 = GetUint16(br);
            Matrix = GetInt32Array(br, 9);
            Width = GetUint16(br) + GetUint16(br) / 100.0f;
            Height = GetUint16(br) + GetUint16(br) / 100.0f;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(base.ToString());

            str.AppendLine("  CreateTime : " + CreateTime.ToString());
            str.AppendLine("  ModificationTime : " + ModificationTime.ToString());
            str.AppendLine("  TrackID : " + TrackID);
            str.AppendLine("  Reserved : " + Reserved1);
            str.AppendLine("  Duration : " + Duration);
            str.AppendLine("  Reserved : " + string.Join(",", Reserved2));
            str.AppendLine("  Layer : " + Layer);
            str.AppendLine("  AlternateGroup : " + AlternateGroup);
            str.AppendLine("  Volume : " + Volume);
            str.AppendLine("  Reserved : " + Reserved3);
            str.AppendLine("  Matrix : " + string.Join(",", Matrix));
            str.AppendLine("  Width : " + Width);
            str.AppendLine("  Height : " + Height);

            return str.ToString();
        }
    }
```

## Media Box

包含在Track Box中，有且僅有一個。

```csharp
    /// <summary>
    /// 包含整個track的媒體信息，比如媒體類型和sample信息，type域爲mdia
    /// </summary>
    public class MediaBox : Box
    {
        /// <summary>
        /// 包含該track的總體信息，針對media來設置，一般與track header一致
        /// </summary>
        public MediaHeaderBox MediaHeader = new MediaHeaderBox();

        /// <summary>
        /// 解釋媒體的播放過程信息
        /// </summary>
        public HandlerReferenceBox Handler = new HandlerReferenceBox();

        /// <summary>
        /// 包含所有描述該track中的媒體信息的對象
        /// </summary>
        public MediaInformationBox MediaInformation = new MediaInformationBox();
        
        /// <summary>
        /// 其他
        /// </summary>
        public List<Box> Boxs = new List<Box>();

        public override void ReadContent(BinaryReader br)
        {
            ulong i = (ulong)headerLength;
            while (i < Size)
            {
                Box box = new Box();
                box.SetParentPath(GetPath());
                box.ReadHeader(br);
                switch (box.Type)
                {
                    case "mdhd":
                        MediaHeader.Copy(box);
                        MediaHeader.ReadFullHeader(br);
                        MediaHeader.ReadContent(br);
                        break;
                    case "hdlr":
                        Handler.Copy(box);
                        Handler.ReadFullHeader(br);
                        Handler.ReadContent(br);
                        break;
                    case "minf":
                        MediaInformation.Copy(box);
                        MediaInformation.ReadContent(br);
                        break;
                    default:
                        box.ReadContent(br);
                        Boxs.Add(box);
                        break;
                }                
                i += box.Size;
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(base.ToString());

            str.Append(MediaHeader.ToString());
            str.Append(Handler.ToString());
            str.Append(MediaInformation.ToString());

            for (int i = 0; i < Boxs.Count; i++)
            {
                str.Append(Boxs[i].ToString());
            }

            return str.ToString();
        }
    }
```

## Media Header Box

包含在Media Box中，有且僅有一個。

```csharp
    /// <summary>
    /// 包含該track的總體信息，內容和track header的內容大致一樣，type域爲mdhd；
    /// track header通常是對指定的track設定相關屬性和內容。
    /// media header是針對獨立的media來設置，一般情況下二者相同。
    /// </summary>
    public class MediaHeaderBox : FullBox
    {
        /// <summary>
        /// 創建時間，表示相對於UTC時間1904-01-01零點的秒數；
        /// 若fullbox中的version爲0佔四個字節，若version爲1佔8個字節；
        /// </summary>
        public DateTime CreateTime;

        /// <summary>
        /// 最後修改時間，表示相對於UTC時間1904-01-01零點的秒數；
        /// 若fullbox中的version爲0佔四個字節，若version爲1佔8個字節；
        /// </summary>
        public DateTime ModificationTime;

        /// <summary>
        /// 文件媒體在1秒時間內的刻度值，即1秒長度的時間單元數，佔四個字節
        /// </summary>
        public uint TimeScale;

        /// <summary>
        /// 該track的時間長度；
        /// 若fullbox中的version爲0佔四個字節，若version爲1佔8個字節；
        /// 用duration和time scale可以計算track時長；
        /// 比如audio track的time scale = 8000, duration = 560128，時長爲70.016秒；
        ///     video track的time scale = 600, duration = 42000，時長爲70秒；
        /// </summary>
        public ulong Duration;

        /// <summary>
        /// 媒體語言碼，佔2個字節；
        /// 最高位爲0，後面15位爲3個字符（見ISO 639-2/T標準中定義）
        /// </summary>
        public string Language;

        /// <summary>
        /// 預留位，佔2個字節
        /// </summary>
        public ushort PreDefined;

        public override void ReadContent(BinaryReader br)
        {
            if (Version == 1)
            {
                ulong seconds = GetUint64(br);
                CreateTime = new DateTime(1904, 1, 1).AddSeconds(seconds);
                seconds = GetUint64(br);
                ModificationTime = new DateTime(1904, 1, 1).AddSeconds(seconds);
                TimeScale = GetUint32(br);
                Duration = GetUint64(br);
            }
            else
            {
                uint seconds = GetUint32(br);
                CreateTime = new DateTime(1904, 1, 1).AddSeconds(seconds).ToLocalTime();
                seconds = GetUint32(br);
                ModificationTime = new DateTime(1904, 1, 1).AddSeconds(seconds).ToLocalTime();
                TimeScale = GetUint32(br);
                Duration = GetUint32(br);
            }

            byte[] arr = br.ReadBytes(2);
            BitArray bitArray = new BitArray(arr);
            // 後面15位爲3個字符
            //Language = ("" + (char)GetByte(bitArray, 1, 5) + (char)GetByte(bitArray, 6, 5) + (char)GetByte(bitArray, 11, 5)).Trim('\0');
            // 以二進制輸出
            Language = Convert.ToString(arr[0], 2).PadLeft(8, '0') + " " + Convert.ToString(arr[1], 2).PadLeft(8, '0');
            PreDefined = GetUint16(br);
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(base.ToString());

            str.AppendLine("  CreateTime : " + CreateTime.ToString());
            str.AppendLine("  ModificationTime : " + ModificationTime.ToString());
            str.AppendLine("  TimeScale : " + TimeScale);
            str.AppendLine("  Duration : " + Duration);
            str.AppendLine("  Language : " + Language);
            str.AppendLine("  PreDefined : " + PreDefined);

            return str.ToString();
        }
    }
```

## Handler Reference Box

包含在Media Box或Meta Box中，有且僅有一個。

```csharp
    /// <summary>
    /// 解釋媒體的播放過程信息，該box也可被包含在meta box中，type域爲hdlr
    /// </summary>
    public class HandlerReferenceBox : FullBox
    {
        /// <summary>
        /// 預定義，佔四個字節
        /// </summary>
        public uint PreDefined;

        /// <summary>
        /// 在media box中，該值爲4個字符，佔四個字節；
        /// vide：video track
        /// soun：audio track
        /// hint：hint track
        /// </summary>
        public string HandlerType;

        /// <summary>
        /// 預留位，uint[3]，佔12個字節
        /// </summary>
        public uint[] Reserved;

        /// <summary>
        /// human‐readable name for the track type
        /// </summary>
        public string Name;

        public override void ReadContent(BinaryReader br)
        {
            PreDefined = GetUint32(br);
            HandlerType = GetString(br, 4);
            Reserved = GetUint32Array(br, 3);
            Name = GetString(br, (int)Size - headerLength - 20);
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(base.ToString());

            str.AppendLine("  PreDefined : " + PreDefined);
            str.AppendLine("  HandlerType : " + HandlerType);
            str.AppendLine("  Reserved : " + string.Join(",", Reserved));
            str.AppendLine("  Name : " + Name);

            return str.ToString();
        }
    }
```

## Media Information Box

包含在Media Box中，有且僅有一個。

```csharp
    /// <summary>
    /// 包含了所有描述該track中的媒體信息的對象，信息存儲在其子box中，type域爲minf；
    /// </summary>
    public class MediaInformationBox : Box
    {
        /// <summary>
        /// 用在視頻track中，包含當前track的視頻描述信息（如視頻編碼等信息）
        /// </summary>
        public VideoMediaHeaderBox VideoMediaHeader;

        /// <summary>
        /// 用在音頻track中，包含當前track的音頻描述信息（如編碼格式等信息）
        /// </summary>
        public SoundMediaHeaderBox SoundMediaHeader;

        /// <summary>
        /// 
        /// </summary>
        public DataInformationBox DataInformation = new DataInformationBox();

        /// <summary>
        /// 
        /// </summary>
        public SampleTableBox SampleTable = new SampleTableBox();

        /// <summary>
        /// 其他
        /// </summary>
        public List<Box> Boxs = new List<Box>();

        public override void ReadContent(BinaryReader br)
        {
            ulong i = (ulong)headerLength;
            while (i < Size)
            {
                Box box = new Box();
                box.SetParentPath(GetPath());
                box.ReadHeader(br);
                switch (box.Type)
                {
                    case "vmhd":
                        VideoMediaHeader = new VideoMediaHeaderBox();
                        VideoMediaHeader.Copy(box);
                        VideoMediaHeader.ReadFullHeader(br);
                        VideoMediaHeader.ReadContent(br);
                        break;
                    case "smhd":
                        SoundMediaHeader = new SoundMediaHeaderBox();
                        SoundMediaHeader.Copy(box);
                        SoundMediaHeader.ReadFullHeader(br);
                        SoundMediaHeader.ReadContent(br);
                        break;
                    case "dinf":
                        DataInformation.Copy(box);
                        DataInformation.ReadContent(br);
                        break;
                    case "stbl":
                        SampleTable.Copy(box);
                        SampleTable.ReadContent(br);
                        break;
                    default:
                        box.ReadContent(br);
                        Boxs.Add(box);
                        break;
                }
                i += box.Size;
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(base.ToString());

            if (VideoMediaHeader != null)
            {
                str.Append(VideoMediaHeader.ToString());
            }
            if (SoundMediaHeader != null)
            {
                str.Append(SoundMediaHeader.ToString());
            }
            str.Append(DataInformation.ToString());
            str.Append(SampleTable.ToString());

            for (int i = 0; i < Boxs.Count; i++)
            {
                str.Append(Boxs[i].ToString());
            }

            return str.ToString();
        }
    }
```

## Video Media Header Box

包含在視頻track的Media Information Box中，有且僅有一個。

```csharp
    /// <summary>
    /// 用在視頻track中，包含當前track的視頻描述信息（如視頻編碼等信息），type域爲vmhd
    /// </summary>
    public class VideoMediaHeaderBox : FullBox
    {
        /// <summary>
        /// 視頻合成模式，爲0時爲拷貝原始圖像，否則與opcolor進行合成，佔兩個字節
        /// </summary>
        public ushort GraphicsMode;

        /// <summary>
        /// {red, green, blue}，佔6個字節
        /// </summary>
        public ushort[] OpColor;

        public override void ReadContent(BinaryReader br)
        {
            GraphicsMode = GetUint16(br);
            OpColor = GetUint16Array(br, 3);
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(base.ToString());

            str.AppendLine("  GraphicsMode : " + GraphicsMode);
            str.AppendLine("  OpColor : " + string.Join(",", OpColor));

            return str.ToString();
        }
    }
```

## Sound Media Header Box

包含在音頻track的Media Information Box中，有且僅有一個。

```csharp
    /// <summary>
    /// 用在音頻track中，包含當前track的音頻描述信息（如編碼格式等信息），type域爲smhd
    /// </summary>
    public class SoundMediaHeaderBox : FullBox
    {
        /// <summary>
        /// 立體聲平衡，佔2個字節，高8位和低8位分別爲小數點整數部分和小數部分；
        /// 一般爲0，-1.0表示全部左聲道，1.0表示全部右聲道；
        /// </summary>
        public float Balance;

        /// <summary>
        /// 保留位，佔2個字節
        /// </summary>
        public ushort Reserved;

        public override void ReadContent(BinaryReader br)
        {
            Balance = br.ReadByte() + br.ReadByte() / 10.0f;
            Reserved = GetUint16(br);
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(base.ToString());

            str.AppendLine("  Balance : " + Balance);
            str.AppendLine("  Reserved : " + Reserved);

            return str.ToString();
        }
    }
```

## Data Information Box

包含在Media Information Box或Meta Box中，在Media Information Box中是必須的，有且僅有一個，在Meta Box中是可選的。

```csharp
    /// <summary>
    /// 解釋如何定位媒體信息，是一個container box。type域爲dinf；
    /// 一般包含一個dref box，即data reference box。
    /// </summary>
    public class DataInformationBox : Box
    {
        /// <summary>
        /// 用來設置當前box描述信息的data_entry
        /// </summary>
        public DataReferenceBox DataReference = new DataReferenceBox();

        /// <summary>
        /// 其他
        /// </summary>
        public List<Box> Boxs = new List<Box>();

        public override void ReadContent(BinaryReader br)
        {
            ulong i = (ulong)headerLength;   
            while (i < Size)
            {
                Box box = new Box();
                box.SetParentPath(GetPath());
                box.ReadHeader(br);
                if (box.Type.Equals("dref"))
                {
                    DataReference.Copy(box);
                    DataReference.ReadFullHeader(br);
                    DataReference.ReadContent(br);
                }
                else
                {
                    box.ReadContent(br);
                    Boxs.Add(box);
                }
                i += box.Size;
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(base.ToString());

            str.Append(DataReference.ToString());

            for (int i = 0; i < Boxs.Count; i++)
            {
                str.Append(Boxs[i].ToString());
            }

            return str.ToString();
        }
    }
```

## Data Reference Box

包含在Data Information Box中，有且僅有一個。

```csharp
    /// <summary>
    /// 用來設置當前Box描述信息的data_entry，type域爲dref；
    /// 包含若干個url或urn，這些box組成一個表，用來定位track數據。
    /// 簡單的說，track可以被分爲若干段，每一段都可以根據url或urn指向的地址來獲取數據，
    /// sample描述中會用這些片段的序號將這些片段組成一個完成的track。
    /// 一般情況下，當數據被完全包含在文件中時，url或urn中的定位字符串是空的。
    /// </summary>
    public class DataReferenceBox : FullBox
    {
        /// <summary>
        /// entry個數
        /// </summary>
        public uint EntryCount;

        public List<DataEntryUrlBox> DataEntryUrls = new List<DataEntryUrlBox>();

        public List<DataEntryUrnBox> DataEntryUrns = new List<DataEntryUrnBox>();

        public override void ReadContent(BinaryReader br)
        {
            EntryCount = GetUint32(br);

            ulong i = (ulong)headerLength + 4;
            while (i < Size)
            {
                FullBox box = new FullBox();
                box.SetParentPath(GetPath());
                box.ReadHeader(br);
                if (box.Type.Equals("url"))
                {
                    DataEntryUrlBox dataUrl = new DataEntryUrlBox();
                    dataUrl.Copy(box);
                    dataUrl.ReadContent(br);
                    DataEntryUrls.Add(dataUrl);
                }
                else if (box.Type.Equals("urn"))
                {
                    DataEntryUrnBox dataUrn = new DataEntryUrnBox();
                    dataUrn.Copy(box);
                    dataUrn.ReadContent(br);
                    DataEntryUrns.Add(dataUrn);
                }
                else
                {
                    box.ReadContent(br);
                }
                i += box.Size;
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(base.ToString());

            str.AppendLine("  EntryCount : " + EntryCount);

            for (int i = 0; i < DataEntryUrls.Count; i++)
            {
                str.Append(DataEntryUrls[i].ToString());
            }

            for (int i = 0; i < DataEntryUrns.Count; i++)
            {
                str.Append(DataEntryUrns[i].ToString());
            }

            return str.ToString();
        }
    }
```

## Data Entry Url Box

包含在Data Reference Box中，至少有一個。

```csharp
    /// <summary>
    /// data reference box下會包含若干個ur或urn，這些box組成一個表，用來定位track數據。type域爲url；
    /// flags值不是固定的，但是有一個特殊的值，0x000001用來表示當前media的數據和moov包含的數據一致；
    /// </summary>
    public class DataEntryUrlBox : FullBox
    {
        /// <summary>
        /// 
        /// </summary>
        public string Location = string.Empty;

        public override void ReadContent(BinaryReader br)
        {
            int length = (int)Size - headerLength;
            if (length > 0)
            {
                Location = GetString(br, length);
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(base.ToString());

            str.AppendLine("  Location : " + Location);

            return str.ToString();
        }
    }
```

## Data Entry Urn Box

包含在Data Reference Box中，至少有一個。

```csharp
    /// <summary>
    /// data reference box下會包含若干個ur或urn，這些box組成一個表，用來定位track數據。type域爲urn；
    /// </summary>
    public class DataEntryUrnBox : FullBox
    {
        /// <summary>
        /// 必須
        /// </summary>
        public string Name = string.Empty;

        /// <summary>
        /// 可選
        /// </summary>
        public string Location = string.Empty;

        public override void ReadContent(BinaryReader br)
        {
            int length = (int)Size - headerLength;
            if (length > 0)
            {
                Name = GetString(br, length);
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(base.ToString());

            str.AppendLine(" Name : " + Name);
            str.AppendLine(" Location : " + Location);

            return str.ToString();
        }
    }
```

## Sample Table Box

包含在Media Information Box中，有且僅有一個。

```csharp
    /// <summary>
    /// 指明sample時序和物理佈局的表，type域爲stbl；
    /// sample是媒體數據存儲的單位，存儲在media的chunk中，chunk和sample的長度均可互不相同；
    /// stbl包含了關於track中sample所有時間和位置的信息，以及sample的編解碼等信息。
    /// 利用這個表，可以解釋sample的時序、類型、大小以及在各自存儲容器中的位置。
    /// stbl是一個container box，其子box包括：sample description box（stsd）、time to sample box（stts）、
    /// sample size box（stsz或stz2）、sample to chunk box（stsc）、chunk offset box（stco或co64）、
    /// composition time to sample box（ctts）、sync sample box（stss）等；
    /// </summary>
    public class SampleTableBox : Box
    {
        /// <summary>
        /// stsd必不可少，該box包含了data reference box進行sample數據檢索的信息。
        /// </summary>
        public SampleDescriptionBox SampleDescription = new SampleDescriptionBox();

        /// <summary>
        /// 時間戳到sample序號的映射表
        /// </summary>
        public TimeToSampleBox TimeToSample = new TimeToSampleBox();

        /// <summary>
        /// 可選
        /// </summary>
        public CompositionOffsetBox CompositionOffset;

        /// <summary>
        /// 定義了每個sample的大小
        /// </summary>
        public SampleSizeBox SampleSize = new SampleSizeBox();

        /// <summary>
        /// 定義sample與chunk的映射關係
        /// </summary>
        public SampleToChunkBox SampleToChunk = new SampleToChunkBox();

        /// <summary>
        /// 描述哪一個sample是關鍵幀
        /// </summary>
        public SyncSampleBox SyncSample;

        /// <summary>
        /// 描述chunk在媒體流中的位置
        /// </summary>
        public ChunkOffsetBox ChunkOffset = new ChunkOffsetBox();

        /// <summary>
        /// 其他
        /// </summary>
        public List<Box> Boxs = new List<Box>();

        public override void ReadContent(BinaryReader br)
        {
            ulong i = (ulong)headerLength;
            while (i < Size)
            {
                Box box = new Box();
                box.SetParentPath(GetPath());
                box.ReadHeader(br);
                switch (box.Type)
                {
                    case "stsd":
                        SampleDescription.Copy(box);
                        SampleDescription.ReadFullHeader(br);
                        SampleDescription.ReadContent(br);
                        break;
                    case "stts":
                        TimeToSample.Copy(box);
                        TimeToSample.ReadFullHeader(br);
                        TimeToSample.ReadContent(br);
                        break;
                    case "stss":
                        SyncSample = new SyncSampleBox();
                        SyncSample.Copy(box);
                        SyncSample.ReadFullHeader(br);
                        SyncSample.ReadContent(br);
                        break;
                    case "stsz":
                        SampleSize.Copy(box);
                        SampleSize.ReadFullHeader(br);
                        SampleSize.ReadContent(br);
                        break;
                    case "stsc":
                        SampleToChunk.Copy(box);
                        SampleToChunk.ReadFullHeader(br);
                        SampleToChunk.ReadContent(br);
                        break;
                    case "stco":
                    case "co64":
                        ChunkOffset.Copy(box);
                        ChunkOffset.ReadFullHeader(br);
                        ChunkOffset.ReadContent(br);
                        break;
                    case "ctts":
                        CompositionOffset = new CompositionOffsetBox();
                        CompositionOffset.Copy(box);
                        CompositionOffset.ReadFullHeader(br);
                        CompositionOffset.ReadContent(br);
                        break;
                    default:
                        box.ReadContent(br);
                        Boxs.Add(box);
                        break;
                }                
                i += box.Size;
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(base.ToString());

            str.Append(SampleDescription.ToString());
            str.Append(TimeToSample.ToString());
            if (CompositionOffset != null)
            {
                str.Append(CompositionOffset.ToString());
            }
            str.Append(SampleSize.ToString());
            str.Append(SampleToChunk.ToString());
            if (SyncSample != null)
            {
                str.Append(SyncSample.ToString());
            }
            str.Append(ChunkOffset.ToString());

            for (int i = 0; i < Boxs.Count; i++)
            {
                str.Append(Boxs[i].ToString());
            }

            return str.ToString();
        }
    }
```

## Sample Description Box

包含在Sample Table Box中，有且僅有一個。

```csharp
    /// <summary>
    /// 定義和描述軌中的採樣的格式的結構，type域爲stsd；
    /// stsd必不可少，且至少包含一個條目，該box包含了data reference box進行sample數據檢索的信息。
    /// 沒有stsd就無法計算media sample的存儲位置。
    /// sdsd包含了編碼的信息，其存儲的信息隨媒體類型不同而不同。
    /// </summary>
    public class SampleDescriptionBox : FullBox
    {
        /// <summary>
        /// entry數目，佔四個字節
        /// </summary>
        public uint EntryCount;

        /// <summary>
        /// stsd在box header和version字段後會有一個entry count字段，
        /// 根據entry的個數，每個entry會有type信息，如“vide”、“sund”等，
        /// 根據type不同sample description會提供不同的信息，例如對於video track，
        /// 會有video sample entry類型信息，對於audio track會有audio sample entry類型信息。
        /// 視頻的編碼類型、寬高、長度、音頻的聲道、採樣等信息都會出現在這個box中。
        /// </summary>
        public List<SampleEntry> SampleEntrys = new List<SampleEntry>();

        public override void ReadContent(BinaryReader br)
        {
            EntryCount = GetUint32(br);
            ulong i = (ulong)headerLength + 4;
            while (i < Size)
            {
                SampleEntry box = new SampleEntry();
                box.SetParentPath(GetPath());
                box.ReadHeader(br);
                box.ReadContent(br);
                SampleEntrys.Add(box);
                i += box.Size;
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(base.ToString());

            str.AppendLine("  EntryCount : " + EntryCount);
            for (int i = 0; i < SampleEntrys.Count; i++)
            {
                str.Append(SampleEntrys[i].ToString());
            }

            return str.ToString();
        }
    }

    /// <summary>
    /// 分爲video sample entry和audio sample entry。
    /// video track中爲video sample entry，type域爲vide；
    /// audio track中爲audio sample entry，type域爲sund；
    /// </summary>
    public class SampleEntry : Box
    {
        /// <summary>
        /// 保留位，佔6個字節
        /// </summary>
        public byte[] Reserved;

        /// <summary>
        /// 佔2個字節
        /// </summary>
        public ushort DataReferenceIndex;

        public override void ReadContent(BinaryReader br)
        {
            Reserved = br.ReadBytes(6);
            DataReferenceIndex = GetUint16(br);

            ulong i = (ulong)headerLength + 8;
            while (i < Size)
            {
                br.ReadByte();
                i++;
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(base.ToString());

            str.AppendLine("  Reserved : " + string.Join(",", Reserved));
            str.AppendLine("  DataReferenceIndex : " + DataReferenceIndex);

            return str.ToString();
        }
    }
```

## Time To Sample Box

包含在Sample Table Box中，有且僅有一個。

```csharp
    /// <summary>
    /// type域爲stts；
    /// stts box存儲了sample的duration，描述了sample時序的映射方法，我們通過它可以找到任何時間的sample。
    /// stts box可以包含一個壓縮的表來映射時間和sample序號，用其他的表來提供每個sample的長度和指針。
    /// 表中每個條目提供了在同一時間偏移量裏面連續的sample序號，以及sample的偏移量。
    /// 遞增這些偏移量，就可以建立一個完整的time to sample表（時間戳到sample序號的映射表）。
    /// </summary>
    public class TimeToSampleBox : FullBox
    {
        /// <summary>
        /// 個數，佔四個字節
        /// </summary>
        public uint EntryCount;

        /// <summary>
        /// 佔EntryCount*4個字節
        /// </summary>
        public List<uint> SampleCounts = new List<uint>();

        /// <summary>
        /// 佔EntryCount*4個字節
        /// </summary>
        public List<uint> SampleDeltas = new List<uint>();

        public override void ReadContent(BinaryReader br)
        {
            EntryCount = GetUint32(br);
            for (int i = 0; i < EntryCount; i++)
            {
                uint sampleCount = GetUint32(br);
                SampleCounts.Add(sampleCount);

                uint sampleDelta = GetUint32(br);
                SampleDeltas.Add(sampleDelta);
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(base.ToString());

            str.AppendLine("  EntryCount : " + EntryCount);
            str.AppendLine("  SampleCount : " + string.Join(",", SampleCounts));
            str.AppendLine("  SampleDeltas : " + string.Join(",", SampleDeltas));

            //// 計算Sample總數
            //uint sampleCount = 0;
            //for (int i = 0; i < SampleCounts.Count; i++)
            //{
            //    sampleCount += SampleCounts[i];
            //}
            //str.AppendLine("  Sample總數 : " + sampleCount);

            //// 計算每個sample的時間戳
            //List<uint> timestamps = new List<uint>();
            //for (int i = 0; i < EntryCount; i++)
            //{
            //    uint j = 0;
            //    while (j < SampleCounts[i])
            //    {
            //        if (timestamps.Count < 1)
            //        {
            //            timestamps.Add(SampleDeltas[i]);
            //        }
            //        else
            //        {
            //            timestamps.Add(timestamps[timestamps.Count - 1] + SampleDeltas[i]);
            //        }
            //        j++;
            //    }
            //}
            //str.AppendLine("  Sample時間戳 : " + string.Join(",", timestamps));
            
            return str.ToString();
        }
    }
```

## Sync Sample Box

包含在Sample Table Box中，有0個或一個。

```csharp
    /// <summary>
    /// type域爲stss;
    /// stss確定media中的關鍵幀。對於壓縮媒體數據，關鍵幀是一系列壓縮序列的開始幀，其解壓縮時不依賴以前的幀，
    /// 而後續幀解壓縮將依賴於這個關鍵幀。stss可以非常緊湊的標記媒體內的隨機存取點，它包含一個sample序號表，
    /// 表內的每一項嚴格按照sample的序號排列，說明了媒體中的那個sample是關鍵幀。如果此表不存在，
    /// 說明每一個sample都是關鍵幀，是一個隨機存取點。
    /// </summary>
    public class SyncSampleBox : FullBox
    {
        /// <summary>
        /// 佔4個字節
        /// </summary>
        public uint EntryCount;

        /// <summary>
        /// 佔EntryCount*4個字節
        /// </summary>
        public List<uint> SampleNumbers = new List<uint>();
        
        public override void ReadContent(BinaryReader br)
        {
            EntryCount = GetUint32(br);
            for (int i = 0; i < EntryCount; i++)
            {
                SampleNumbers.Add(GetUint32(br));
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(base.ToString());

            str.AppendLine("  EntrySize : " + EntryCount);
            str.AppendLine("  SampleNumbers : " + string.Join(",", SampleNumbers));
            
            return str.ToString();
        }
    }
```

## Sample Size Box

包含在Sample Table Box中，有且僅有一個。

```csharp
    /// <summary>
    /// type域爲stsz或stz2；
    /// stsz定義了每個sample的大小，包含了媒體中全部sample的數目和一張給出每個sample大小的表。
    /// 這個box相對來說體積是比較大的。
    /// </summary>
    public class SampleSizeBox : FullBox
    {
        /// <summary>
        /// 佔四個字節
        /// </summary>
        public uint SampleSize;

        /// <summary>
        /// 佔四個字節
        /// </summary>
        public uint SampleCount;

        /// <summary>
        /// 若SampleSize=0，則佔SampleCount*4個字節
        /// </summary>
        public List<uint> EntrySizes = new List<uint>();

        public override void ReadContent(BinaryReader br)
        {
            SampleSize = GetUint32(br);
            SampleCount = GetUint32(br);
            if (SampleSize == 0)
            {
                for (int i = 0; i < SampleCount; i++)
                {
                    EntrySizes.Add(GetUint32(br));
                }
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(base.ToString());

            str.AppendLine("  SampleSize : " + SampleSize);
            str.AppendLine("  SampleCount : " + SampleCount);
            str.AppendLine("  EntrySize : " + string.Join(",", EntrySizes));

            //// 計算sample總大小
            //uint sampleSizeSum = 0;
            //for (int i = 0; i < SampleCount; i++)
            //{
            //    sampleSizeSum += EntrySizes[i];
            //}
            //str.AppendLine("  Sample總大小 : " + sampleSizeSum);

            return str.ToString();
        }
    }
```

## Sample To Chunk Box

包含在Smaple Table Box中，有且僅有一個。

```csharp
    /// <summary>
    /// type域爲stsc；
    /// 用chunk組織sample可以方便優化數據獲取，一個chunk包含一個或多個sample。
    /// stsc中用一個表描述了sample與chunk的映射關係，查看這張表就可以找到包含指定sample的chunk，從而找到這個sample。
    /// </summary>
    public class SampleToChunkBox : FullBox
    {
        /// <summary>
        /// 佔4個字節
        /// </summary>
        public uint EntryCount;

        /// <summary>
        /// 佔EntryCount*4個字節
        /// </summary>
        public List<uint> FirstChunks = new List<uint>();

        /// <summary>
        /// 佔EntryCount*4個字節
        /// </summary>
        public List<uint> SamplesPerChunks = new List<uint>();

        /// <summary>
        /// 佔EntryCount*4個字節
        /// </summary>
        public List<uint> SmapleDescriptionIndexs = new List<uint>();

        public override void ReadContent(BinaryReader br)
        {
            EntryCount = GetUint32(br);
            for (int i = 0; i < EntryCount; i++)
            {
                FirstChunks.Add(GetUint32(br));
                SamplesPerChunks.Add(GetUint32(br));
                SmapleDescriptionIndexs.Add(GetUint32(br));
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(base.ToString());

            str.AppendLine("  EntrySize : " + EntryCount);
            str.AppendLine("  FirstChunks : " + string.Join(",", FirstChunks));
            str.AppendLine("  SamplesPerChunks : " + string.Join(",", SamplesPerChunks));
            str.AppendLine("  SmapleDescriptionIndexs : " + string.Join(",", SmapleDescriptionIndexs));

            return str.ToString();
        }
    }
```

## Chunk Offset Box

包含在Sample Table Box中，有且僅有一個。

```csharp
    /// <summary>
    /// type域爲stco表示32位；type域爲co64表示64位；
    /// stco定義了每個chunk在媒體流中的位置，sample的偏移可以根據其他box推算出來。
    /// 位置有兩種可能，32位和64位的，在一個表中只會有一種可能，這個位置是在整個文件中的，
    /// 而不是在任何box中的，這樣做就可以直接在文件中找到媒體位置，而不用解釋box。
    /// 需要注意的是一旦前面的box有了任何改變，這張表都要重新建立，因爲位置信息已經改變了。
    /// </summary>
    public class ChunkOffsetBox : FullBox
    {
        /// <summary>
        /// 佔四個字節
        /// </summary>
        public uint EntryCount;

        /// <summary>
        /// 若type爲stco使用，佔EntryCount*4個字節
        /// </summary>
        public List<uint> ChunkOffset32;

        /// <summary>
        /// 若type爲co64使用，佔EntryCount*8個字節
        /// </summary>
        public List<ulong> ChunkOffset64;

        public override void ReadContent(BinaryReader br)
        {
            EntryCount = GetUint32(br);
            if (Type.Equals("stco"))
            {
                ChunkOffset32 = new List<uint>();
                for (int i = 0; i < EntryCount; i++)
                {
                    ChunkOffset32.Add(GetUint32(br));
                }
            }
            else
            {
                ChunkOffset64 = new List<ulong>();
                for (int i = 0; i < EntryCount; i++)
                {
                    ChunkOffset64.Add(GetUint64(br));
                }
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(base.ToString());

            str.AppendLine("  EntrySize : " + EntryCount);
            if (Type.Equals("stco"))
            {
                str.AppendLine("  ChunkOffset : " + string.Join(",", ChunkOffset32));
            }
            else
            {
                str.AppendLine("  ChunkOffset : " + string.Join(",", ChunkOffset64));
            }

            return str.ToString();
        }
    }
```

## Composition Time To Sample Box

包含在Sample Table Box中，有0個或1個。

```csharp
    /// <summary>
    /// type域爲ctts
    /// </summary>
    public class CompositionOffsetBox : FullBox
    {
        /// <summary>
        /// 佔四個字節
        /// </summary>
        public uint EntryCount;

        /// <summary>
        /// 佔EntryCount*4個字節
        /// </summary>
        public List<uint> SampleCounts = new List<uint>();

        /// <summary>
        /// 佔EntryCount*4個字節
        /// version = 0時，sample offset類型爲uint32；
        /// version = 1時，sample offset類型爲int32；
        /// </summary>
        public List<uint> SampleOffsetUint32 = new List<uint>();

        /// <summary>
        /// 佔EntryCount*4個字節
        /// version = 0時，sample offset類型爲uint32；
        /// version = 1時，sample offset類型爲int32；
        /// </summary>
        public List<int> SampleOffsetInt32 = new List<int>();

        public override void ReadContent(BinaryReader br)
        {
            EntryCount = GetUint32(br);
            for (int i = 0; i < EntryCount; i++)
            {
                uint sampleCount = GetUint32(br);
                SampleCounts.Add(sampleCount);

                if (Version == 0)
                {
                    uint offsetUint = GetUint32(br);
                    SampleOffsetUint32.Add(offsetUint);
                }
                else
                {
                    int offsetInt = GetInt32(br);
                    SampleOffsetInt32.Add(offsetInt);
                }
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(base.ToString());

            str.AppendLine("  EntryCount : " + EntryCount);
            str.AppendLine("  SampleCount : " + string.Join(",", SampleCounts));
            str.AppendLine("  SampleOffset : " + (Version == 0 ? string.Join(",", SampleOffsetUint32) : string.Join(",", SampleOffsetInt32)));

            return str.ToString();
        }
    }
```

若要獲取指定track下指定sample的原始數據：

- 通過 TimeToSampleBox 可獲取指定sample的時間偏移
- 通過 SampleToChunkBox 可獲取sample所在的chunk
- 通過 ChunkOffsetBox 可獲取chunk的偏移量
- 通過 SampleSizeBox 可獲取chunk下sample的大小
- 根據chunk偏移量及其中sample的大小可獲取指定sample的偏移量
- 根據指定sample的偏移量及大小可在 MediaDataBox 中獲取sample的數據

------

# 解析輸出

```bash
FileTypeBox
  Size : 24
  Type : ftyp
  MajorBrand : mp42
  MinorVersion : 
  CompatibleBrands : isommp42
MediaDataBox
  Size : 2473246
  Type : mdat
  ContentLength : 2473238
FreeSpaceBox
  Size : 4520
  Type : free
  ContentLength : 4512
MovieBox
  Size : 1870
  Type : moov
MovieBox\MovieHeaderBox
  Size : 108
  Type : mvhd
  Version : 0
  Flags : 00-00-00
  CreateTime : 2019/12/17 17:13:43
  ModificationTime : 2019/12/17 17:13:43
  TimeScale : 1000
  Duration : 3772
  TimeLength : 3.772 s
  Rate : 1
  Volume : 1
  Reserved : 00-00-00-00-00-00-00-00-00-00
  Matrix : 65536,0,0,0,65536,0,0,0,1073741824
  PreDefined : 00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00
  NextTrackId : 3
MovieBox\MetaBox
  Size : 121
  Type : meta
  Version : 0
  Flags : 00-00-21
  ContentLength : 109
MovieBox\TrackBox
  Size : 1038
  Type : trak
MovieBox\TrackBox\TrackHeaderBox
  Size : 92
  Type : tkhd
  Version : 0
  Flags : 00-00-07
  CreateTime : 2019/12/17 17:13:43
  ModificationTime : 2019/12/17 17:13:43
  TrackID : 1
  Reserved : 0
  Duration : 3772
  Reserved : 0,0
  Layer : 0
  AlternateGroup : 0
  Volume : 0
  Reserved : 0
  Matrix : 65536,0,0,0,65536,0,0,0,1073741824
  Width : 640
  Height : 480
MovieBox\TrackBox\MediaBox
  Size : 938
  Type : mdia
MovieBox\TrackBox\MediaBox\MediaHeaderBox
  Size : 32
  Type : mdhd
  Version : 0
  Flags : 00-00-00
  CreateTime : 2019/12/17 17:13:43
  ModificationTime : 2019/12/17 17:13:43
  TimeScale : 90000
  Duration : 339467
  Language : 00000000 00000000
  PreDefined : 0
MovieBox\TrackBox\MediaBox\HandlerReferenceBox
  Size : 44
  Type : hdlr
  Version : 0
  Flags : 00-00-00
  PreDefined : 0
  HandlerType : vide
  Reserved : 0,0,0
  Name : VideoHandle
MovieBox\TrackBox\MediaBox\MediaInformationBox
  Size : 854
  Type : minf
MovieBox\TrackBox\MediaBox\MediaInformationBox\VideoMediaHeaderBox
  Size : 20
  Type : vmhd
  Version : 0
  Flags : 00-00-01
  GraphicsMode : 0
  OpColor : 0,0,0
MovieBox\TrackBox\MediaBox\MediaInformationBox\DataInformationBox
  Size : 36
  Type : dinf
MovieBox\TrackBox\MediaBox\MediaInformationBox\DataInformationBox\DataReferenceBox
  Size : 28
  Type : dref
  Version : 0
  Flags : 00-00-00
  EntryCount : 1
MovieBox\TrackBox\MediaBox\MediaInformationBox\DataInformationBox\DataReferenceBox\DataEntryUrlBox
  Size : 12
  Type : url
  Version : 0
  Flags : 00-00-01
  Location : 
MovieBox\TrackBox\MediaBox\MediaInformationBox\SampleTableBox
  Size : 790
  Type : stbl
MovieBox\TrackBox\MediaBox\MediaInformationBox\SampleTableBox\SampleDescriptionBox
  Size : 178
  Type : stsd
  Version : 0
  Flags : 00-00-00
  EntryCount : 1
MovieBox\TrackBox\MediaBox\MediaInformationBox\SampleTableBox\SampleDescriptionBox\SampleEntry
  Size : 162
  Type : avc1
  Reserved : 0,0,0,0,0,0
  DataReferenceIndex : 1
MovieBox\TrackBox\MediaBox\MediaInformationBox\SampleTableBox\TimeToSampleBox
  Size : 168
  Type : stts
  Version : 0
  Flags : 00-00-00
  EntryCount : 19
  SampleCount : 1,14,1,21,1,6,2,2,2,2,2,2,2,2,2,2,2,1,8
  SampleDeltas : 6493,4499,4509,4500,4490,4501,4492,4507,4492,4507,4493,4506,4493,4507,4492,4507,4492,4508,4499
MovieBox\TrackBox\MediaBox\MediaInformationBox\SampleTableBox\SampleSizeBox
  Size : 320
  Type : stsz
  Version : 0
  Flags : 00-00-00
  SampleSize : 0
  SampleCount : 75
  EntrySize : 28384,20762,32986,37220,31942,35826,35359,34416,33380,35938,32239,34326,35127,33610,36638,33771,35001,32392,29924,68881,39600,36986,34851,42119,30216,33564,27977,26736,29889,29433,31844,27765,27300,21469,28343,25686,29222,27196,68539,42875,38770,32598,36496,31465,34818,33051,27156,28712,25484,28587,27679,29602,31300,24207,24289,25392,26633,60898,40983,41188,34165,33186,32904,36045,31128,30491,34074,30812,26314,25990,28260,27787,30652,33405,23297
MovieBox\TrackBox\MediaBox\MediaInformationBox\SampleTableBox\SampleToChunkBox
  Size : 52
  Type : stsc
  Version : 0
  Flags : 00-00-00
  EntrySize : 3
  FirstChunks : 1,2,4
  SamplesPerChunks : 23,21,10
  SmapleDescriptionIndexs : 1,1,1
MovieBox\TrackBox\MediaBox\MediaInformationBox\SampleTableBox\SyncSampleBox
  Size : 32
  Type : stss
  Version : 0
  Flags : 00-00-00
  EntrySize : 4
  SampleNumbers : 1,20,39,58
MovieBox\TrackBox\MediaBox\MediaInformationBox\SampleTableBox\ChunkOffsetBox
  Size : 32
  Type : stco
  Version : 0
  Flags : 00-00-00
  EntrySize : 4
  ChunkOffset : 6422,818110,1509107,2188005
MovieBox\TrackBox
  Size : 595
  Type : trak
MovieBox\TrackBox\TrackHeaderBox
  Size : 92
  Type : tkhd
  Version : 0
  Flags : 00-00-07
  CreateTime : 2019/12/17 17:13:43
  ModificationTime : 2019/12/17 17:13:43
  TrackID : 2
  Reserved : 0
  Duration : 3712
  Reserved : 0,0
  Layer : 0
  AlternateGroup : 0
  Volume : 1
  Reserved : 0
  Matrix : 65536,0,0,0,65536,0,0,0,1073741824
  Width : 0
  Height : 0
MovieBox\TrackBox\MediaBox
  Size : 495
  Type : mdia
MovieBox\TrackBox\MediaBox\MediaHeaderBox
  Size : 32
  Type : mdhd
  Version : 0
  Flags : 00-00-00
  CreateTime : 2019/12/17 17:13:43
  ModificationTime : 2019/12/17 17:13:43
  TimeScale : 8000
  Duration : 29696
  Language : 00000000 00000000
  PreDefined : 0
MovieBox\TrackBox\MediaBox\HandlerReferenceBox
  Size : 44
  Type : hdlr
  Version : 0
  Flags : 00-00-00
  PreDefined : 0
  HandlerType : soun
  Reserved : 0,0,0
  Name : SoundHandle
MovieBox\TrackBox\MediaBox\MediaInformationBox
  Size : 411
  Type : minf
MovieBox\TrackBox\MediaBox\MediaInformationBox\SoundMediaHeaderBox
  Size : 16
  Type : smhd
  Version : 0
  Flags : 00-00-00
  Balance : 0
  Reserved : 0
MovieBox\TrackBox\MediaBox\MediaInformationBox\DataInformationBox
  Size : 36
  Type : dinf
MovieBox\TrackBox\MediaBox\MediaInformationBox\DataInformationBox\DataReferenceBox
  Size : 28
  Type : dref
  Version : 0
  Flags : 00-00-00
  EntryCount : 1
MovieBox\TrackBox\MediaBox\MediaInformationBox\DataInformationBox\DataReferenceBox\DataEntryUrlBox
  Size : 12
  Type : url
  Version : 0
  Flags : 00-00-01
  Location : 
MovieBox\TrackBox\MediaBox\MediaInformationBox\SampleTableBox
  Size : 351
  Type : stbl
MovieBox\TrackBox\MediaBox\MediaInformationBox\SampleTableBox\SampleDescriptionBox
  Size : 91
  Type : stsd
  Version : 0
  Flags : 00-00-00
  EntryCount : 1
MovieBox\TrackBox\MediaBox\MediaInformationBox\SampleTableBox\SampleDescriptionBox\SampleEntry
  Size : 75
  Type : mp4a
  Reserved : 0,0,0,0,0,0
  DataReferenceIndex : 1
MovieBox\TrackBox\MediaBox\MediaInformationBox\SampleTableBox\TimeToSampleBox
  Size : 32
  Type : stts
  Version : 0
  Flags : 00-00-00
  EntryCount : 2
  SampleCount : 1,28
  SampleDeltas : 1024,1024
MovieBox\TrackBox\MediaBox\MediaInformationBox\SampleTableBox\SampleSizeBox
  Size : 136
  Type : stsz
  Version : 0
  Flags : 00-00-00
  SampleSize : 0
  SampleCount : 29
  EntrySize : 195,225,272,239,229,207,209,199,168,186,169,207,181,181,169,186,187,215,187,197,196,178,178,172,192,191,198,191,184
MovieBox\TrackBox\MediaBox\MediaInformationBox\SampleTableBox\SampleToChunkBox
  Size : 52
  Type : stsc
  Version : 0
  Flags : 00-00-00
  EntrySize : 3
  FirstChunks : 1,2,4
  SamplesPerChunks : 10,8,3
  SmapleDescriptionIndexs : 1,1,1
MovieBox\TrackBox\MediaBox\MediaInformationBox\SampleTableBox\ChunkOffsetBox
  Size : 32
  Type : stco
  Version : 0
  Flags : 00-00-00
  EntrySize : 4
  ChunkOffset : 815981,1507612,2186514,2479087
```

------

## 參考資料

- [MPEG-4標準](https://baike.baidu.com/item/MPEG-4标准/7590976)
- [MPEG-4 Part 11](https://baike.baidu.com/item/MPEG-4 Part 11/3647619)
- [Mp4文件格式解析](https://www.cnblogs.com/CoderTian/p/8277965.html)