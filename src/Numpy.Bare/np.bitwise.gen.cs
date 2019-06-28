// Copyright (c) 2019 by the SciSharp Team
// Code generated by CodeMinion: https://github.com/SciSharp/CodeMinion

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Python.Runtime;
using Numpy.Models;

namespace Numpy
{
    public static partial class np
    {
        
        /// <summary>
        ///	Compute the bit-wise AND of two arrays element-wise.<br></br>
        ///	
        ///	
        ///	Computes the bit-wise AND of the underlying binary representation of
        ///	the integers in the input arrays.<br></br>
        ///	 This ufunc implements the C/Python
        ///	operator &amp;.
        /// </summary>
        /// <param name="x2">
        ///	Only integer and boolean types are handled.<br></br>
        ///	
        /// </param>
        /// <param name="x1">
        ///	Only integer and boolean types are handled.<br></br>
        ///	
        /// </param>
        /// <param name="out">
        ///	A location into which the result is stored.<br></br>
        ///	 If provided, it must have
        ///	a shape that the inputs broadcast to.<br></br>
        ///	 If not provided or None,
        ///	a freshly-allocated array is returned.<br></br>
        ///	 A tuple (possible only as a
        ///	keyword argument) must have length equal to the number of outputs.<br></br>
        ///	
        /// </param>
        /// <param name="where">
        ///	Values of True indicate to calculate the ufunc at that position, values
        ///	of False indicate to leave the value in the output alone.<br></br>
        ///	
        /// </param>
        /// <returns>
        ///	Result.<br></br>
        ///	
        ///	This is a scalar if both x1 and x2 are scalars.<br></br>
        ///	
        /// </returns>
        public static NDarray bitwise_and(NDarray x2, NDarray x1, NDarray @out = null, NDarray @where = null)
            => NumPy.Instance.bitwise_and(x2, x1, @out:@out, @where:@where);
        
        /// <summary>
        ///	Compute the bit-wise OR of two arrays element-wise.<br></br>
        ///	
        ///	
        ///	Computes the bit-wise OR of the underlying binary representation of
        ///	the integers in the input arrays.<br></br>
        ///	 This ufunc implements the C/Python
        ///	operator |.
        /// </summary>
        /// <param name="x2">
        ///	Only integer and boolean types are handled.<br></br>
        ///	
        /// </param>
        /// <param name="x1">
        ///	Only integer and boolean types are handled.<br></br>
        ///	
        /// </param>
        /// <param name="out">
        ///	A location into which the result is stored.<br></br>
        ///	 If provided, it must have
        ///	a shape that the inputs broadcast to.<br></br>
        ///	 If not provided or None,
        ///	a freshly-allocated array is returned.<br></br>
        ///	 A tuple (possible only as a
        ///	keyword argument) must have length equal to the number of outputs.<br></br>
        ///	
        /// </param>
        /// <param name="where">
        ///	Values of True indicate to calculate the ufunc at that position, values
        ///	of False indicate to leave the value in the output alone.<br></br>
        ///	
        /// </param>
        /// <returns>
        ///	Result.<br></br>
        ///	
        ///	This is a scalar if both x1 and x2 are scalars.<br></br>
        ///	
        /// </returns>
        public static NDarray bitwise_or(NDarray x2, NDarray x1, NDarray @out = null, NDarray @where = null)
            => NumPy.Instance.bitwise_or(x2, x1, @out:@out, @where:@where);
        
        /// <summary>
        ///	Compute the bit-wise XOR of two arrays element-wise.<br></br>
        ///	
        ///	
        ///	Computes the bit-wise XOR of the underlying binary representation of
        ///	the integers in the input arrays.<br></br>
        ///	 This ufunc implements the C/Python
        ///	operator ^.
        /// </summary>
        /// <param name="x2">
        ///	Only integer and boolean types are handled.<br></br>
        ///	
        /// </param>
        /// <param name="x1">
        ///	Only integer and boolean types are handled.<br></br>
        ///	
        /// </param>
        /// <param name="out">
        ///	A location into which the result is stored.<br></br>
        ///	 If provided, it must have
        ///	a shape that the inputs broadcast to.<br></br>
        ///	 If not provided or None,
        ///	a freshly-allocated array is returned.<br></br>
        ///	 A tuple (possible only as a
        ///	keyword argument) must have length equal to the number of outputs.<br></br>
        ///	
        /// </param>
        /// <param name="where">
        ///	Values of True indicate to calculate the ufunc at that position, values
        ///	of False indicate to leave the value in the output alone.<br></br>
        ///	
        /// </param>
        /// <returns>
        ///	Result.<br></br>
        ///	
        ///	This is a scalar if both x1 and x2 are scalars.<br></br>
        ///	
        /// </returns>
        public static NDarray bitwise_xor(NDarray x2, NDarray x1, NDarray @out = null, NDarray @where = null)
            => NumPy.Instance.bitwise_xor(x2, x1, @out:@out, @where:@where);
        
        /// <summary>
        ///	Compute bit-wise inversion, or bit-wise NOT, element-wise.<br></br>
        ///	
        ///	
        ///	Computes the bit-wise NOT of the underlying binary representation of
        ///	the integers in the input arrays.<br></br>
        ///	 This ufunc implements the C/Python
        ///	operator ~.
        ///	
        ///	For signed integer inputs, the two’s complement is returned.<br></br>
        ///	  In a
        ///	two’s-complement system negative numbers are represented by the two’s
        ///	complement of the absolute value.<br></br>
        ///	 This is the most common method of
        ///	representing signed integers on computers [1].<br></br>
        ///	 A N-bit
        ///	two’s-complement system can represent every integer in the range
        ///	 to .
        ///	
        ///	Notes
        ///	
        ///	bitwise_not is an alias for invert:
        ///	
        ///	References
        /// </summary>
        /// <param name="x">
        ///	Only integer and boolean types are handled.<br></br>
        ///	
        /// </param>
        /// <param name="out">
        ///	A location into which the result is stored.<br></br>
        ///	 If provided, it must have
        ///	a shape that the inputs broadcast to.<br></br>
        ///	 If not provided or None,
        ///	a freshly-allocated array is returned.<br></br>
        ///	 A tuple (possible only as a
        ///	keyword argument) must have length equal to the number of outputs.<br></br>
        ///	
        /// </param>
        /// <param name="where">
        ///	Values of True indicate to calculate the ufunc at that position, values
        ///	of False indicate to leave the value in the output alone.<br></br>
        ///	
        /// </param>
        /// <returns>
        ///	Result.<br></br>
        ///	
        ///	This is a scalar if x is a scalar.<br></br>
        ///	
        /// </returns>
        public static NDarray invert(NDarray x, NDarray @out = null, NDarray @where = null)
            => NumPy.Instance.invert(x, @out:@out, @where:@where);
        
        /// <summary>
        ///	Shift the bits of an integer to the left.<br></br>
        ///	
        ///	
        ///	Bits are shifted to the left by appending x2 0s at the right of x1.
        ///	Since the internal representation of numbers is in binary format, this
        ///	operation is equivalent to multiplying x1 by 2**x2.
        /// </summary>
        /// <param name="x1">
        ///	Input values.<br></br>
        ///	
        /// </param>
        /// <param name="x2">
        ///	Number of zeros to append to x1. Has to be non-negative.<br></br>
        ///	
        /// </param>
        /// <param name="out">
        ///	A location into which the result is stored.<br></br>
        ///	 If provided, it must have
        ///	a shape that the inputs broadcast to.<br></br>
        ///	 If not provided or None,
        ///	a freshly-allocated array is returned.<br></br>
        ///	 A tuple (possible only as a
        ///	keyword argument) must have length equal to the number of outputs.<br></br>
        ///	
        /// </param>
        /// <param name="where">
        ///	Values of True indicate to calculate the ufunc at that position, values
        ///	of False indicate to leave the value in the output alone.<br></br>
        ///	
        /// </param>
        /// <returns>
        ///	Return x1 with bits shifted x2 times to the left.<br></br>
        ///	
        ///	This is a scalar if both x1 and x2 are scalars.<br></br>
        ///	
        /// </returns>
        public static NDarray<int> left_shift(NDarray<int> x1, NDarray<int> x2, NDarray @out = null, NDarray @where = null)
            => NumPy.Instance.left_shift(x1, x2, @out:@out, @where:@where);
        
        /// <summary>
        ///	Shift the bits of an integer to the right.<br></br>
        ///	
        ///	
        ///	Bits are shifted to the right x2.  Because the internal
        ///	representation of numbers is in binary format, this operation is
        ///	equivalent to dividing x1 by 2**x2.
        /// </summary>
        /// <param name="x1">
        ///	Input values.<br></br>
        ///	
        /// </param>
        /// <param name="x2">
        ///	Number of bits to remove at the right of x1.
        /// </param>
        /// <param name="out">
        ///	A location into which the result is stored.<br></br>
        ///	 If provided, it must have
        ///	a shape that the inputs broadcast to.<br></br>
        ///	 If not provided or None,
        ///	a freshly-allocated array is returned.<br></br>
        ///	 A tuple (possible only as a
        ///	keyword argument) must have length equal to the number of outputs.<br></br>
        ///	
        /// </param>
        /// <param name="where">
        ///	Values of True indicate to calculate the ufunc at that position, values
        ///	of False indicate to leave the value in the output alone.<br></br>
        ///	
        /// </param>
        /// <returns>
        ///	Return x1 with bits shifted x2 times to the right.<br></br>
        ///	
        ///	This is a scalar if both x1 and x2 are scalars.<br></br>
        ///	
        /// </returns>
        public static NDarray right_shift(NDarray x1, NDarray x2, NDarray @out = null, NDarray @where = null)
            => NumPy.Instance.right_shift(x1, x2, @out:@out, @where:@where);
        
        /// <summary>
        ///	Packs the elements of a binary-valued array into bits in a uint8 array.<br></br>
        ///	
        ///	
        ///	The result is padded to full bytes by inserting zero bits at the end.<br></br>
        ///	
        /// </summary>
        /// <param name="myarray">
        ///	An array of integers or booleans whose elements should be packed to
        ///	bits.<br></br>
        ///	
        /// </param>
        /// <param name="axis">
        ///	The dimension over which bit-packing is done.<br></br>
        ///	
        ///	None implies packing the flattened array.<br></br>
        ///	
        /// </param>
        /// <returns>
        ///	Array of type uint8 whose elements represent bits corresponding to the
        ///	logical (0 or nonzero) value of the input elements.<br></br>
        ///	 The shape of
        ///	packed has the same number of dimensions as the input (unless axis
        ///	is None, in which case the output is 1-D).<br></br>
        ///	
        /// </returns>
        public static NDarray packbits(NDarray myarray, int? axis = null)
            => NumPy.Instance.packbits(myarray, axis:axis);
        
        /// <summary>
        ///	Unpacks elements of a uint8 array into a binary-valued output array.<br></br>
        ///	
        ///	
        ///	Each element of myarray represents a bit-field that should be unpacked
        ///	into a binary-valued output array.<br></br>
        ///	 The shape of the output array is either
        ///	1-D (if axis is None) or the same shape as the input array with unpacking
        ///	done along the axis specified.<br></br>
        ///	
        /// </summary>
        /// <param name="myarray">
        ///	Input array.<br></br>
        ///	
        /// </param>
        /// <param name="axis">
        ///	The dimension over which bit-unpacking is done.<br></br>
        ///	
        ///	None implies unpacking the flattened array.<br></br>
        ///	
        /// </param>
        /// <returns>
        ///	The elements are binary-valued (0 or 1).<br></br>
        ///	
        /// </returns>
        public static NDarray unpackbits(NDarray myarray, int? axis = null)
            => NumPy.Instance.unpackbits(myarray, axis:axis);
        
        /// <summary>
        ///	Return the binary representation of the input number as a string.<br></br>
        ///	
        ///	
        ///	For negative numbers, if width is not given, a minus sign is added to the
        ///	front.<br></br>
        ///	 If width is given, the two’s complement of the number is
        ///	returned, with respect to that width.<br></br>
        ///	
        ///	
        ///	In a two’s-complement system negative numbers are represented by the two’s
        ///	complement of the absolute value.<br></br>
        ///	 This is the most common method of
        ///	representing signed integers on computers [1].<br></br>
        ///	 A N-bit two’s-complement
        ///	system can represent every integer in the range
        ///	 to .
        ///	
        ///	Notes
        ///	
        ///	binary_repr is equivalent to using base_repr with base 2, but about 25x
        ///	faster.<br></br>
        ///	
        ///	
        ///	References
        /// </summary>
        /// <param name="num">
        ///	Only an integer decimal number can be used.<br></br>
        ///	
        /// </param>
        /// <param name="width">
        ///	The length of the returned string if num is positive, or the length
        ///	of the two’s complement if num is negative, provided that width is
        ///	at least a sufficient number of bits for num to be represented in the
        ///	designated form.<br></br>
        ///	
        ///	
        ///	If the width value is insufficient, it will be ignored, and num will
        ///	be returned in binary (num &gt; 0) or two’s complement (num &lt; 0) form
        ///	with its width equal to the minimum number of bits needed to represent
        ///	the number in the designated form.<br></br>
        ///	 This behavior is deprecated and will
        ///	later raise an error.<br></br>
        ///	
        /// </param>
        /// <returns>
        ///	Binary representation of num or two’s complement of num.<br></br>
        ///	
        /// </returns>
        public static string binary_repr(int num, int? width = null)
            => NumPy.Instance.binary_repr(num, width:width);
        
        
    }
}
