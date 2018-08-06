﻿using System;

namespace ALSASharp
{
    // snd_pcm_stream_t
    public enum SoundPcmStreamType
    {
        Playback,  // Playback stream
        Capture   // Capture stream
    }

    public static class DeviceNameHints
    {
        public const string NAME = "NAME";  // name of device
        public const string DESC = "DESC";  // description of device
        public const string IOID = "IOID";  // input / output identification ("Input" or "Output"), NULL means both
    }

    // snd_pcm_access_t
    public enum SoundPcmAccess
    {
        SND_PCM_ACCESS_MMAP_INTERLEAVED,     // mmap access with simple interleaved channels
        SND_PCM_ACCESS_MMAP_NONINTERLEAVED,  // mmap access with simple non interleaved channels
        SND_PCM_ACCESS_MMAP_COMPLEX,         // mmap access with complex placement
        SND_PCM_ACCESS_RW_INTERLEAVED,       // snd_pcm_readi/snd_pcm_writei access
        SND_PCM_ACCESS_RW_NONINTERLEAVED     // snd_pcm_readn/snd_pcm_writen access
    }

    // snd_pcm_format_t
    public enum SoundPcmFormat
    {
        UNKNOWN = -1,  // Unknown
        S8 = 0,   // Signed 8 bit
        U8,   // Unsigned 8 bit
        S16_LE,   // Signed 16 bit Little Endian
        S16_BE,   // Signed 16 bit Big Endian
        U16_LE,   // Unsigned 16 bit Little Endian
        U16_BE,   // Unsigned 16 bit Big Endian
        S24_LE,   // Signed 24 bit Little Endian using low three bytes in 32-bit word
        S24_BE,   // Signed 24 bit Big Endian using low three bytes in 32-bit word
        U24_LE,   // Unsigned 24 bit Little Endian using low three bytes in 32-bit word
        U24_BE,   // Unsigned 24 bit Big Endian using low three bytes in 32-bit word
        S32_LE,   // Signed 32 bit Little Endian
        S32_BE,   // Signed 32 bit Big Endian
        U32_LE,   // Unsigned 32 bit Little Endian
        U32_BE,   // Unsigned 32 bit Big Endian
        FLOAT_LE,     // Float 32 bit Little Endian, Range -1.0 to 1.0
        FLOAT_BE,     // Float 32 bit Big Endian, Range -1.0 to 1.0
        FLOAT64_LE,   // Float 64 bit Little Endian, Range -1.0 to 1.0
        FLOAT64_BE,   // Float 64 bit Big Endian, Range -1.0 to 1.0
        IEC958_SUBFRAME_LE,   // IEC-958 Little Endian
        IEC958_SUBFRAME_BE,   // IEC-958 Big Endian
        MU_LAW,   // Mu-Law
        A_LAW,    // A-Law
        IMA_ADPCM,    // Ima-ADPCM
        MPEG,     // MPEG
        GSM,  // GSM
        SPECIAL = 31,  // Special
        S24_3LE = 32,  // Signed 24bit Little Endian in 3bytes format
        S24_3BE,  // Signed 24bit Big Endian in 3bytes format
        U24_3LE,  // Unsigned 24bit Little Endian in 3bytes format
        U24_3BE,  // Unsigned 24bit Big Endian in 3bytes format
        S20_3LE,  // Signed 20bit Little Endian in 3bytes format
        S20_3BE,  // Signed 20bit Big Endian in 3bytes format 
        U20_3LE,  // Unsigned 20bit Little Endian in 3bytes format
        U20_3BE,  // Unsigned 20bit Big Endian in 3bytes format
        S18_3LE,  // Signed 18bit Little Endian in 3bytes format
        S18_3BE,  // Signed 18bit Big Endian in 3bytes format
        U18_3LE,  // Unsigned 18bit Little Endian in 3bytes format
        U18_3BE,  // Unsigned 18bit Big Endian in 3bytes format
        G723_24, // G.723 (ADPCM) 24 kbit/s, 8 samples in 3 bytes
        G723_24_1B, // G.723 (ADPCM) 24 kbit/s, 1 sample in 1 byte
        G723_40, // G.723 (ADPCM) 40 kbit/s, 8 samples in 3 bytes
        G723_40_1B, // G.723 (ADPCM) 40 kbit/s, 1 sample in 1 byte
        DSD_U8, // Direct Stream Digital (DSD) in 1-byte samples (x8)
        DSD_U16_LE,// Direct Stream Digital (DSD) in 2-byte samples (x16)
        DSD_U32_LE, // Direct Stream Digital (DSD) in 4-byte samples (x32)
        DSD_U16_BE, // Direct Stream Digital (DSD) in 2-byte samples (x16)
        DSD_U32_BE // Direct Stream Digital (DSD) in 4-byte samples (x32)
    }

    /// <summary>
    /// Collection of convenient <see cref="SoundPcmFormat"/> enumeration constants.
    /// </summary>
    public static class SoundPcmFormats
    {
        public static readonly SoundPcmFormat S16; // Signed 16 bit CPU endian
        public static readonly SoundPcmFormat U16; // Unsigned 16 bit CPU endian
        public static readonly SoundPcmFormat S24; // Signed 24 bit CPU endian
        public static readonly SoundPcmFormat U24; // Unsigned 24 bit CPU endian
        public static readonly SoundPcmFormat S32; // Signed 32 bit CPU endian
        public static readonly SoundPcmFormat U32; // Unsigned 32 bit CPU endian
        public static readonly SoundPcmFormat FLOAT; // Float 32 bit CPU endian
        public static readonly SoundPcmFormat FLOAT64; // Float 64 bit CPU endian
        public static readonly SoundPcmFormat IEC958_SUBFRAME; // IEC-958 CPU Endian

        static SoundPcmFormats()
        {
            if (BitConverter.IsLittleEndian)
            {
                S16 = SoundPcmFormat.S16_LE;
                U16 = SoundPcmFormat.U16_LE;
                S24 = SoundPcmFormat.S24_LE;
                U24 = SoundPcmFormat.U24_LE;
                S32 = SoundPcmFormat.S32_LE;
                U32 = SoundPcmFormat.U32_LE;
                FLOAT = SoundPcmFormat.FLOAT_LE;
                FLOAT64 = SoundPcmFormat.FLOAT64_LE;
                IEC958_SUBFRAME = SoundPcmFormat.IEC958_SUBFRAME_LE;
            }
            else
            {
                S16 = SoundPcmFormat.S16_BE;
                U16 = SoundPcmFormat.U16_BE;
                S24 = SoundPcmFormat.S24_BE;
                U24 = SoundPcmFormat.U24_BE;
                S32 = SoundPcmFormat.S32_BE;
                U32 = SoundPcmFormat.U32_BE;
                FLOAT = SoundPcmFormat.FLOAT_BE;
                FLOAT64 = SoundPcmFormat.FLOAT64_BE;
                IEC958_SUBFRAME = SoundPcmFormat.IEC958_SUBFRAME_BE;
            }
        }
    }
}
