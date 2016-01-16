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
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ffprobeStream
    {

        private string codec_typeField;

        private decimal durationField;

        private bool durationFieldSpecified;

        private string codec_nameField;

        private ushort widthField;

        private bool widthFieldSpecified;

        private ushort heightField;

        private bool heightFieldSpecified;

        private string r_frame_rateField;

        private string avg_frame_rateField;

        private uint nb_framesField;

        private bool nb_framesFieldSpecified;

        private uint nb_read_framesField;

        private bool nb_read_framesFieldSpecified;

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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nb_framesSpecified
        {
            get
            {
                return this.nb_framesFieldSpecified;
            }
            set
            {
                this.nb_framesFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint nb_read_frames
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
    }
























    /* ================================================================================

    <?xml version="1.0" encoding="UTF-8"?>
    <ffprobe>
        <streams>
            <stream index="0" codec_name="h264" codec_long_name="H.264 / AVC / MPEG-4 AVC / MPEG-4 part 10" profile="Baseline" codec_type="video" codec_time_base="1/180000" codec_tag_string="avc1" codec_tag="0x31637661" width="1280" height="720" has_b_frames="0" sample_aspect_ratio="1:1" display_aspect_ratio="16:9" pix_fmt="yuv420p" level="31" chroma_location="left" is_avc="1" nal_length_size="4" r_frame_rate="30/1" avg_frame_rate="9495000/316319" time_base="1/90000" start_pts="0" start_time="0.000000" duration_ts="1265276" duration="14.058622" bit_rate="11996509" bits_per_raw_sample="8" nb_frames="422" nb_read_frames="422">
                <disposition default="1" dub="0" original="0" comment="0" lyrics="0" karaoke="0" forced="0" hearing_impaired="0" visual_impaired="0" clean_effects="0" attached_pic="0"/>
                <tag key="creation_time" value="2015-10-03 15:18:05"/>
                <tag key="language" value="eng"/>
                <tag key="handler_name" value="VideoHandle"/>
            </stream>
            <stream index="1" codec_name="aac" codec_long_name="AAC (Advanced Audio Coding)" profile="LC" codec_type="audio" codec_time_base="1/48000" codec_tag_string="mp4a" codec_tag="0x6134706d" sample_fmt="fltp" sample_rate="48000" channels="2" channel_layout="stereo" bits_per_sample="0" r_frame_rate="0/0" avg_frame_rate="0/0" time_base="1/48000" start_pts="0" start_time="0.000000" duration_ts="686650" duration="14.305208" bit_rate="155870" nb_frames="670" nb_read_frames="670">
                <disposition default="1" dub="0" original="0" comment="0" lyrics="0" karaoke="0" forced="0" hearing_impaired="0" visual_impaired="0" clean_effects="0" attached_pic="0"/>
                <tag key="creation_time" value="2015-10-03 15:18:05"/>
                <tag key="language" value="eng"/>
                <tag key="handler_name" value="SoundHandle"/>
            </stream>
            <stream index="0" codec_name="mjpeg" codec_long_name="MJPEG (Motion JPEG)" codec_type="video" codec_time_base="33333/1000000" codec_tag_string="MJPG" codec_tag="0x47504a4d" width="1280" height="720" has_b_frames="0" sample_aspect_ratio="0:1" display_aspect_ratio="0:1" pix_fmt="yuvj422p" level="-99" color_range="pc" color_space="bt470bg" chroma_location="center" r_frame_rate="1000000/33333" avg_frame_rate="1000000/33333" time_base="33333/1000000" start_pts="0" start_time="0.000000" duration_ts="210" duration="6.999930" bit_rate="24790911" bits_per_raw_sample="8" nb_frames="210" nb_read_frames="197">
                <disposition default="0" dub="0" original="0" comment="0" lyrics="0" karaoke="0" forced="0" hearing_impaired="0" visual_impaired="0" clean_effects="0" attached_pic="0"/>
            </stream>
            <stream index="1" codec_name="pcm_s16le" codec_long_name="PCM signed 16-bit little-endian" codec_type="audio" codec_time_base="1/32000" codec_tag_string="[1][0][0][0]" codec_tag="0x0001" sample_fmt="s16" sample_rate="32000" channels="1" bits_per_sample="16" r_frame_rate="0/0" avg_frame_rate="0/0" time_base="1/32000" start_pts="0" start_time="0.000000" bit_rate="512000" nb_frames="112000" nb_read_frames="210">
                <disposition default="0" dub="0" original="0" comment="0" lyrics="0" karaoke="0" forced="0" hearing_impaired="0" visual_impaired="0" clean_effects="0" attached_pic="0"/>
            </stream>
            <stream index="0" codec_name="h264" codec_long_name="H.264 / AVC / MPEG-4 AVC / MPEG-4 part 10" profile="High" codec_type="video" codec_time_base="1/46" codec_tag_string="avc1" codec_tag="0x31637661" width="640" height="360" has_b_frames="2" sample_aspect_ratio="1:1" display_aspect_ratio="16:9" pix_fmt="yuv420p" level="31" chroma_location="left" is_avc="1" nal_length_size="4" r_frame_rate="23/1" avg_frame_rate="23/1" time_base="1/23000" start_pts="2000" start_time="0.086957" duration_ts="142305000" duration="6187.173913" bit_rate="239323" bits_per_raw_sample="8" nb_frames="142305">
                <disposition default="1" dub="0" original="0" comment="0" lyrics="0" karaoke="0" forced="0" hearing_impaired="0" visual_impaired="0" clean_effects="0" attached_pic="0"/>
                <tag key="creation_time" value="2012-04-10 03:55:08"/>
                <tag key="language" value="und"/>
                <tag key="handler_name" value="GPAC ISO Video Handler"/>
            </stream>
            <stream index="1" codec_name="aac" codec_long_name="AAC (Advanced Audio Coding)" profile="LC" codec_type="audio" codec_time_base="1/44100" codec_tag_string="mp4a" codec_tag="0x6134706d" sample_fmt="fltp" sample_rate="44100" channels="2" channel_layout="stereo" bits_per_sample="0" r_frame_rate="0/0" avg_frame_rate="0/0" time_base="1/44100" start_pts="0" start_time="0.000000" duration_ts="272876544" duration="6187.676735" bit_rate="109560" nb_frames="266481">
                <disposition default="1" dub="0" original="0" comment="0" lyrics="0" karaoke="0" forced="0" hearing_impaired="0" visual_impaired="0" clean_effects="0" attached_pic="0"/>
                <tag key="creation_time" value="2012-04-10 03:55:13"/>
                <tag key="language" value="und"/>
                <tag key="handler_name" value="GPAC ISO Audio Handler"/>
            </stream>
            <stream index="0" codec_name="h264" codec_long_name="H.264 / AVC / MPEG-4 AVC / MPEG-4 part 10" profile="Baseline" codec_type="video" codec_time_base="1/60288" codec_tag_string="avc1" codec_tag="0x31637661" width="640" height="352" coded_width="640" coded_height="352" has_b_frames="0" sample_aspect_ratio="0:1" display_aspect_ratio="0:1" pix_fmt="yuv420p" level="30" chroma_location="left" refs="1" is_avc="true" nal_length_size="4" r_frame_rate="3768/125" avg_frame_rate="3768/125" time_base="1/30144" start_pts="0" start_time="0.000000" duration_ts="206000" duration="6.833864" bit_rate="1952039" bits_per_raw_sample="8" nb_frames="206">
                <disposition default="1" dub="0" original="0" comment="0" lyrics="0" karaoke="0" forced="0" hearing_impaired="0" visual_impaired="0" clean_effects="0" attached_pic="0"/>
                <tag key="creation_time" value="2016-01-14 01:16:34"/>
                <tag key="language" value="eng"/>
                <tag key="encoder" value="AVC Coding"/>
            </stream>
        </streams>

        <format filename="C:\Users\Mikhail\Videos\20151003_171749.mp4" nb_streams="2" nb_programs="0" format_name="mov,mp4,m4a,3gp,3g2,mj2" format_long_name="QuickTime / MOV" start_time="0.000000" duration="14.293000" size="21765552" bit_rate="12182496" probe_score="100">
            <tag key="major_brand" value="isom"/>
            <tag key="minor_version" value="0"/>
            <tag key="compatible_brands" value="isom3gp4"/>
            <tag key="creation_time" value="2015-10-03 15:18:05"/>
        </format>
    </ffprobe>



    <ffprobe>
        <streams>
            <stream codec_type="video" duration="6187.676735" codec_name="h264" width="1280" height="720" r_frame_rate="3768/125" avg_frame_rate="3768/125" nb_frames="4221231" nb_read_frames="4212132">
            </stream>
            <stream codec_type="video" >
            </stream>
        </streams>
    </ffprobe>


     ======================================================= */





}
