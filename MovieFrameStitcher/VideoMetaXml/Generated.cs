﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFrameStitcher.VideoMetaXml
{





    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class ffprobe
    {

        private ffprobeStream[] streamsField;

        private ffprobeFormat formatField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("stream", IsNullable = false)]
        public ffprobeStream[] streams
        {
            get
            {
                return this.streamsField;
            }
            set
            {
                this.streamsField = value;
            }
        }

        /// <remarks/>
        public ffprobeFormat format
        {
            get
            {
                return this.formatField;
            }
            set
            {
                this.formatField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ffprobeStream
    {

        private ffprobeStreamDisposition dispositionField;

        private ffprobeStreamTag[] tagField;

        private byte indexField;

        private string codec_nameField;

        private string codec_long_nameField;

        private string profileField;

        private string codec_typeField;

        private string codec_time_baseField;

        private string codec_tag_stringField;

        private string codec_tagField;

        private ushort widthField;

        private bool widthFieldSpecified;

        private ushort heightField;

        private bool heightFieldSpecified;

        private byte has_b_framesField;

        private bool has_b_framesFieldSpecified;

        private string sample_aspect_ratioField;

        private string display_aspect_ratioField;

        private string pix_fmtField;

        private sbyte levelField;

        private bool levelFieldSpecified;

        private string chroma_locationField;

        private byte is_avcField;

        private bool is_avcFieldSpecified;

        private byte nal_length_sizeField;

        private bool nal_length_sizeFieldSpecified;

        private string r_frame_rateField;

        private string avg_frame_rateField;

        private string time_baseField;

        private ushort start_ptsField;

        private decimal start_timeField;

        private uint duration_tsField;

        private bool duration_tsFieldSpecified;

        private decimal durationField;

        private bool durationFieldSpecified;

        private uint bit_rateField;

        private byte bits_per_raw_sampleField;

        private bool bits_per_raw_sampleFieldSpecified;

        private uint nb_framesField;

        private ushort nb_read_framesField;

        private bool nb_read_framesFieldSpecified;

        private string sample_fmtField;

        private ushort sample_rateField;

        private bool sample_rateFieldSpecified;

        private byte channelsField;

        private bool channelsFieldSpecified;

        private string channel_layoutField;

        private byte bits_per_sampleField;

        private bool bits_per_sampleFieldSpecified;

        private string color_rangeField;

        private string color_spaceField;

        /// <remarks/>
        public ffprobeStreamDisposition disposition
        {
            get
            {
                return this.dispositionField;
            }
            set
            {
                this.dispositionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tag")]
        public ffprobeStreamTag[] tag
        {
            get
            {
                return this.tagField;
            }
            set
            {
                this.tagField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte index
        {
            get
            {
                return this.indexField;
            }
            set
            {
                this.indexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codec_name
        {
            get
            {
                return this.codec_nameField;
            }
            set
            {
                this.codec_nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codec_long_name
        {
            get
            {
                return this.codec_long_nameField;
            }
            set
            {
                this.codec_long_nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string profile
        {
            get
            {
                return this.profileField;
            }
            set
            {
                this.profileField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codec_type
        {
            get
            {
                return this.codec_typeField;
            }
            set
            {
                this.codec_typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codec_time_base
        {
            get
            {
                return this.codec_time_baseField;
            }
            set
            {
                this.codec_time_baseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codec_tag_string
        {
            get
            {
                return this.codec_tag_stringField;
            }
            set
            {
                this.codec_tag_stringField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codec_tag
        {
            get
            {
                return this.codec_tagField;
            }
            set
            {
                this.codec_tagField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool widthSpecified
        {
            get
            {
                return this.widthFieldSpecified;
            }
            set
            {
                this.widthFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool heightSpecified
        {
            get
            {
                return this.heightFieldSpecified;
            }
            set
            {
                this.heightFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte has_b_frames
        {
            get
            {
                return this.has_b_framesField;
            }
            set
            {
                this.has_b_framesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool has_b_framesSpecified
        {
            get
            {
                return this.has_b_framesFieldSpecified;
            }
            set
            {
                this.has_b_framesFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string sample_aspect_ratio
        {
            get
            {
                return this.sample_aspect_ratioField;
            }
            set
            {
                this.sample_aspect_ratioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string display_aspect_ratio
        {
            get
            {
                return this.display_aspect_ratioField;
            }
            set
            {
                this.display_aspect_ratioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string pix_fmt
        {
            get
            {
                return this.pix_fmtField;
            }
            set
            {
                this.pix_fmtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public sbyte level
        {
            get
            {
                return this.levelField;
            }
            set
            {
                this.levelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool levelSpecified
        {
            get
            {
                return this.levelFieldSpecified;
            }
            set
            {
                this.levelFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string chroma_location
        {
            get
            {
                return this.chroma_locationField;
            }
            set
            {
                this.chroma_locationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte is_avc
        {
            get
            {
                return this.is_avcField;
            }
            set
            {
                this.is_avcField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool is_avcSpecified
        {
            get
            {
                return this.is_avcFieldSpecified;
            }
            set
            {
                this.is_avcFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte nal_length_size
        {
            get
            {
                return this.nal_length_sizeField;
            }
            set
            {
                this.nal_length_sizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nal_length_sizeSpecified
        {
            get
            {
                return this.nal_length_sizeFieldSpecified;
            }
            set
            {
                this.nal_length_sizeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string r_frame_rate
        {
            get
            {
                return this.r_frame_rateField;
            }
            set
            {
                this.r_frame_rateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string avg_frame_rate
        {
            get
            {
                return this.avg_frame_rateField;
            }
            set
            {
                this.avg_frame_rateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string time_base
        {
            get
            {
                return this.time_baseField;
            }
            set
            {
                this.time_baseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort start_pts
        {
            get
            {
                return this.start_ptsField;
            }
            set
            {
                this.start_ptsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal start_time
        {
            get
            {
                return this.start_timeField;
            }
            set
            {
                this.start_timeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint duration_ts
        {
            get
            {
                return this.duration_tsField;
            }
            set
            {
                this.duration_tsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool duration_tsSpecified
        {
            get
            {
                return this.duration_tsFieldSpecified;
            }
            set
            {
                this.duration_tsFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool durationSpecified
        {
            get
            {
                return this.durationFieldSpecified;
            }
            set
            {
                this.durationFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint bit_rate
        {
            get
            {
                return this.bit_rateField;
            }
            set
            {
                this.bit_rateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte bits_per_raw_sample
        {
            get
            {
                return this.bits_per_raw_sampleField;
            }
            set
            {
                this.bits_per_raw_sampleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bits_per_raw_sampleSpecified
        {
            get
            {
                return this.bits_per_raw_sampleFieldSpecified;
            }
            set
            {
                this.bits_per_raw_sampleFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint nb_frames
        {
            get
            {
                return this.nb_framesField;
            }
            set
            {
                this.nb_framesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort nb_read_frames
        {
            get
            {
                return this.nb_read_framesField;
            }
            set
            {
                this.nb_read_framesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nb_read_framesSpecified
        {
            get
            {
                return this.nb_read_framesFieldSpecified;
            }
            set
            {
                this.nb_read_framesFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string sample_fmt
        {
            get
            {
                return this.sample_fmtField;
            }
            set
            {
                this.sample_fmtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort sample_rate
        {
            get
            {
                return this.sample_rateField;
            }
            set
            {
                this.sample_rateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sample_rateSpecified
        {
            get
            {
                return this.sample_rateFieldSpecified;
            }
            set
            {
                this.sample_rateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte channels
        {
            get
            {
                return this.channelsField;
            }
            set
            {
                this.channelsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool channelsSpecified
        {
            get
            {
                return this.channelsFieldSpecified;
            }
            set
            {
                this.channelsFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string channel_layout
        {
            get
            {
                return this.channel_layoutField;
            }
            set
            {
                this.channel_layoutField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte bits_per_sample
        {
            get
            {
                return this.bits_per_sampleField;
            }
            set
            {
                this.bits_per_sampleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bits_per_sampleSpecified
        {
            get
            {
                return this.bits_per_sampleFieldSpecified;
            }
            set
            {
                this.bits_per_sampleFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string color_range
        {
            get
            {
                return this.color_rangeField;
            }
            set
            {
                this.color_rangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string color_space
        {
            get
            {
                return this.color_spaceField;
            }
            set
            {
                this.color_spaceField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ffprobeStreamDisposition
    {

        private byte defaultField;

        private byte dubField;

        private byte originalField;

        private byte commentField;

        private byte lyricsField;

        private byte karaokeField;

        private byte forcedField;

        private byte hearing_impairedField;

        private byte visual_impairedField;

        private byte clean_effectsField;

        private byte attached_picField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte @default
        {
            get
            {
                return this.defaultField;
            }
            set
            {
                this.defaultField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte dub
        {
            get
            {
                return this.dubField;
            }
            set
            {
                this.dubField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte original
        {
            get
            {
                return this.originalField;
            }
            set
            {
                this.originalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte comment
        {
            get
            {
                return this.commentField;
            }
            set
            {
                this.commentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte lyrics
        {
            get
            {
                return this.lyricsField;
            }
            set
            {
                this.lyricsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte karaoke
        {
            get
            {
                return this.karaokeField;
            }
            set
            {
                this.karaokeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte forced
        {
            get
            {
                return this.forcedField;
            }
            set
            {
                this.forcedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte hearing_impaired
        {
            get
            {
                return this.hearing_impairedField;
            }
            set
            {
                this.hearing_impairedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte visual_impaired
        {
            get
            {
                return this.visual_impairedField;
            }
            set
            {
                this.visual_impairedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte clean_effects
        {
            get
            {
                return this.clean_effectsField;
            }
            set
            {
                this.clean_effectsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte attached_pic
        {
            get
            {
                return this.attached_picField;
            }
            set
            {
                this.attached_picField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ffprobeStreamTag
    {

        private string keyField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ffprobeFormat
    {

        private ffprobeFormatTag[] tagField;

        private string filenameField;

        private byte nb_streamsField;

        private byte nb_programsField;

        private string format_nameField;

        private string format_long_nameField;

        private decimal start_timeField;

        private decimal durationField;

        private uint sizeField;

        private uint bit_rateField;

        private byte probe_scoreField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tag")]
        public ffprobeFormatTag[] tag
        {
            get
            {
                return this.tagField;
            }
            set
            {
                this.tagField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string filename
        {
            get
            {
                return this.filenameField;
            }
            set
            {
                this.filenameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte nb_streams
        {
            get
            {
                return this.nb_streamsField;
            }
            set
            {
                this.nb_streamsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte nb_programs
        {
            get
            {
                return this.nb_programsField;
            }
            set
            {
                this.nb_programsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string format_name
        {
            get
            {
                return this.format_nameField;
            }
            set
            {
                this.format_nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string format_long_name
        {
            get
            {
                return this.format_long_nameField;
            }
            set
            {
                this.format_long_nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal start_time
        {
            get
            {
                return this.start_timeField;
            }
            set
            {
                this.start_timeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint size
        {
            get
            {
                return this.sizeField;
            }
            set
            {
                this.sizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint bit_rate
        {
            get
            {
                return this.bit_rateField;
            }
            set
            {
                this.bit_rateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte probe_score
        {
            get
            {
                return this.probe_scoreField;
            }
            set
            {
                this.probe_scoreField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ffprobeFormatTag
    {

        private string keyField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }









}
