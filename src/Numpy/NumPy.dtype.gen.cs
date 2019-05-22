using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Python.Runtime;
using Python.Included;
using NumSharp;

namespace Numpy
{
    public partial class NumPy
    {
        
        /// <summary>
        /// compatible: Python bool
        /// </summary>
        public Dtype bool_
        {
            get
            {
                //auto-generated code, do not change
                dynamic py = self.GetAttr("bool_");
                return ToCsharp<Dtype>(py);
            }
        }
        
        /// <summary>
        /// 8 bits
        /// </summary>
        public Dtype bool8
        {
            get
            {
                //auto-generated code, do not change
                dynamic py = self.GetAttr("bool8");
                return ToCsharp<Dtype>(py);
            }
        }
        
        /// <summary>
        /// compatible: C char
        /// </summary>
        public Dtype @byte
        {
            get
            {
                //auto-generated code, do not change
                dynamic py = self.GetAttr("byte");
                return ToCsharp<Dtype>(py);
            }
        }
        
        /// <summary>
        /// compatible: C short
        /// </summary>
        public Dtype @short
        {
            get
            {
                //auto-generated code, do not change
                dynamic py = self.GetAttr("short");
                return ToCsharp<Dtype>(py);
            }
        }
        
        /// <summary>
        /// compatible: C int
        /// </summary>
        public Dtype intc
        {
            get
            {
                //auto-generated code, do not change
                dynamic py = self.GetAttr("intc");
                return ToCsharp<Dtype>(py);
            }
        }
        
        /// <summary>
        /// compatible: Python int
        /// </summary>
        public Dtype int_
        {
            get
            {
                //auto-generated code, do not change
                dynamic py = self.GetAttr("int_");
                return ToCsharp<Dtype>(py);
            }
        }
        
        /// <summary>
        /// compatible: C long long
        /// </summary>
        public Dtype longlong
        {
            get
            {
                //auto-generated code, do not change
                dynamic py = self.GetAttr("longlong");
                return ToCsharp<Dtype>(py);
            }
        }
        
        /// <summary>
        /// large enough to fit a pointer
        /// </summary>
        public Dtype intp
        {
            get
            {
                //auto-generated code, do not change
                dynamic py = self.GetAttr("intp");
                return ToCsharp<Dtype>(py);
            }
        }
        
        /// <summary>
        /// 8 bits
        /// </summary>
        public Dtype int8
        {
            get
            {
                //auto-generated code, do not change
                dynamic py = self.GetAttr("int8");
                return ToCsharp<Dtype>(py);
            }
        }
        
        /// <summary>
        /// 16 bits
        /// </summary>
        public Dtype int16
        {
            get
            {
                //auto-generated code, do not change
                dynamic py = self.GetAttr("int16");
                return ToCsharp<Dtype>(py);
            }
        }
        
        /// <summary>
        /// 32 bits
        /// </summary>
        public Dtype int32
        {
            get
            {
                //auto-generated code, do not change
                dynamic py = self.GetAttr("int32");
                return ToCsharp<Dtype>(py);
            }
        }
        
        /// <summary>
        /// 64 bits
        /// </summary>
        public Dtype int64
        {
            get
            {
                //auto-generated code, do not change
                dynamic py = self.GetAttr("int64");
                return ToCsharp<Dtype>(py);
            }
        }
        
        /// <summary>
        /// compatible: C unsigned char
        /// </summary>
        public Dtype ubyte
        {
            get
            {
                //auto-generated code, do not change
                dynamic py = self.GetAttr("ubyte");
                return ToCsharp<Dtype>(py);
            }
        }
        
        /// <summary>
        /// compatible: C unsigned short
        /// </summary>
        public Dtype @ushort
        {
            get
            {
                //auto-generated code, do not change
                dynamic py = self.GetAttr("ushort");
                return ToCsharp<Dtype>(py);
            }
        }
        
        /// <summary>
        /// compatible: C unsigned int
        /// </summary>
        public Dtype uintc
        {
            get
            {
                //auto-generated code, do not change
                dynamic py = self.GetAttr("uintc");
                return ToCsharp<Dtype>(py);
            }
        }
        
        /// <summary>
        /// compatible: Python int
        /// </summary>
        public Dtype @uint
        {
            get
            {
                //auto-generated code, do not change
                dynamic py = self.GetAttr("uint");
                return ToCsharp<Dtype>(py);
            }
        }
        
        /// <summary>
        /// compatible: C long long
        /// </summary>
        public Dtype ulonglong
        {
            get
            {
                //auto-generated code, do not change
                dynamic py = self.GetAttr("ulonglong");
                return ToCsharp<Dtype>(py);
            }
        }
        
        /// <summary>
        /// large enough to fit a pointer
        /// </summary>
        public Dtype uintp
        {
            get
            {
                //auto-generated code, do not change
                dynamic py = self.GetAttr("uintp");
                return ToCsharp<Dtype>(py);
            }
        }
        
        /// <summary>
        /// 8 bits
        /// </summary>
        public Dtype uint8
        {
            get
            {
                //auto-generated code, do not change
                dynamic py = self.GetAttr("uint8");
                return ToCsharp<Dtype>(py);
            }
        }
        
        /// <summary>
        /// 16 bits
        /// </summary>
        public Dtype uint16
        {
            get
            {
                //auto-generated code, do not change
                dynamic py = self.GetAttr("uint16");
                return ToCsharp<Dtype>(py);
            }
        }
        
        /// <summary>
        /// 32 bits
        /// </summary>
        public Dtype uint32
        {
            get
            {
                //auto-generated code, do not change
                dynamic py = self.GetAttr("uint32");
                return ToCsharp<Dtype>(py);
            }
        }
        
        /// <summary>
        /// 64 bits
        /// </summary>
        public Dtype uint64
        {
            get
            {
                //auto-generated code, do not change
                dynamic py = self.GetAttr("uint64");
                return ToCsharp<Dtype>(py);
            }
        }
        
        /// <summary>
        /// &#160;
        /// </summary>
        public Dtype half
        {
            get
            {
                //auto-generated code, do not change
                dynamic py = self.GetAttr("half");
                return ToCsharp<Dtype>(py);
            }
        }
        
        /// <summary>
        /// compatible: C float
        /// </summary>
        public Dtype single
        {
            get
            {
                //auto-generated code, do not change
                dynamic py = self.GetAttr("single");
                return ToCsharp<Dtype>(py);
            }
        }
        
        /// <summary>
        /// compatible: C double
        /// </summary>
        public Dtype @double
        {
            get
            {
                //auto-generated code, do not change
                dynamic py = self.GetAttr("double");
                return ToCsharp<Dtype>(py);
            }
        }
        
        /// <summary>
        /// compatible: Python float
        /// </summary>
        public Dtype float_
        {
            get
            {
                //auto-generated code, do not change
                dynamic py = self.GetAttr("float_");
                return ToCsharp<Dtype>(py);
            }
        }
        
        /// <summary>
        /// compatible: C long float
        /// </summary>
        public Dtype longfloat
        {
            get
            {
                //auto-generated code, do not change
                dynamic py = self.GetAttr("longfloat");
                return ToCsharp<Dtype>(py);
            }
        }
        
        /// <summary>
        /// 16 bits
        /// </summary>
        public Dtype float16
        {
            get
            {
                //auto-generated code, do not change
                dynamic py = self.GetAttr("float16");
                return ToCsharp<Dtype>(py);
            }
        }
        
        /// <summary>
        /// 32 bits
        /// </summary>
        public Dtype float32
        {
            get
            {
                //auto-generated code, do not change
                dynamic py = self.GetAttr("float32");
                return ToCsharp<Dtype>(py);
            }
        }
        
        /// <summary>
        /// 64 bits
        /// </summary>
        public Dtype float64
        {
            get
            {
                //auto-generated code, do not change
                dynamic py = self.GetAttr("float64");
                return ToCsharp<Dtype>(py);
            }
        }
        
        /// <summary>
        /// 96 bits, platform?
        /// </summary>
        public Dtype float96
        {
            get
            {
                //auto-generated code, do not change
                dynamic py = self.GetAttr("float96");
                return ToCsharp<Dtype>(py);
            }
        }
        
        /// <summary>
        /// 128 bits, platform?
        /// </summary>
        public Dtype float128
        {
            get
            {
                //auto-generated code, do not change
                dynamic py = self.GetAttr("float128");
                return ToCsharp<Dtype>(py);
            }
        }
        
        /// <summary>
        /// &#160;
        /// </summary>
        public Dtype csingle
        {
            get
            {
                //auto-generated code, do not change
                dynamic py = self.GetAttr("csingle");
                return ToCsharp<Dtype>(py);
            }
        }
        
        /// <summary>
        /// compatible: Python complex
        /// </summary>
        public Dtype complex_
        {
            get
            {
                //auto-generated code, do not change
                dynamic py = self.GetAttr("complex_");
                return ToCsharp<Dtype>(py);
            }
        }
        
        /// <summary>
        /// &#160;
        /// </summary>
        public Dtype clongfloat
        {
            get
            {
                //auto-generated code, do not change
                dynamic py = self.GetAttr("clongfloat");
                return ToCsharp<Dtype>(py);
            }
        }
        
        /// <summary>
        /// two 32-bit floats
        /// </summary>
        public Dtype complex64
        {
            get
            {
                //auto-generated code, do not change
                dynamic py = self.GetAttr("complex64");
                return ToCsharp<Dtype>(py);
            }
        }
        
        /// <summary>
        /// two 64-bit floats
        /// </summary>
        public Dtype complex128
        {
            get
            {
                //auto-generated code, do not change
                dynamic py = self.GetAttr("complex128");
                return ToCsharp<Dtype>(py);
            }
        }
        
        /// <summary>
        /// two 96-bit floats,
        /// platform?
        /// </summary>
        public Dtype complex192
        {
            get
            {
                //auto-generated code, do not change
                dynamic py = self.GetAttr("complex192");
                return ToCsharp<Dtype>(py);
            }
        }
        
        /// <summary>
        /// two 128-bit floats,
        /// platform?
        /// </summary>
        public Dtype complex256
        {
            get
            {
                //auto-generated code, do not change
                dynamic py = self.GetAttr("complex256");
                return ToCsharp<Dtype>(py);
            }
        }
        
        /// <summary>
        /// any Python object
        /// </summary>
        public Dtype object_
        {
            get
            {
                //auto-generated code, do not change
                dynamic py = self.GetAttr("object_");
                return ToCsharp<Dtype>(py);
            }
        }
        
        /// <summary>
        /// compatible: Python bytes
        /// </summary>
        public Dtype bytes_
        {
            get
            {
                //auto-generated code, do not change
                dynamic py = self.GetAttr("bytes_");
                return ToCsharp<Dtype>(py);
            }
        }
        
        /// <summary>
        /// compatible: Python unicode/str
        /// </summary>
        public Dtype unicode_
        {
            get
            {
                //auto-generated code, do not change
                dynamic py = self.GetAttr("unicode_");
                return ToCsharp<Dtype>(py);
            }
        }
        
        /// <summary>
        /// &#160;
        /// </summary>
        public Dtype @void
        {
            get
            {
                //auto-generated code, do not change
                dynamic py = self.GetAttr("void");
                return ToCsharp<Dtype>(py);
            }
        }
        
    }
}
