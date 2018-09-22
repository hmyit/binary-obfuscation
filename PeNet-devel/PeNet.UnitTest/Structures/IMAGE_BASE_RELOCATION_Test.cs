﻿/***********************************************************************
Copyright 2016 Stefan Hausotte

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.

*************************************************************************/

using System;
using Xunit;
using PeNet.Structures;

namespace PeNet.UnitTest.Structures
{
    
    public class IMAGE_BASE_RELOCATION_Test
    {
        [Fact]
        public void SizeOfBlockIsBiggerThanRelocDirSize_Test()
        {
            var rawImageBaseRelocBroken = new byte[]
            {0x00, 0x00, 0x01, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x30, 0xC4, 0x30};
            Assert.Throws<ArgumentOutOfRangeException>(() => new IMAGE_BASE_RELOCATION(rawImageBaseRelocBroken, 0, 0));
        }

        [Fact]
        public void OffsetIsBiggerThanBuffer_Test()
        {
            Assert.Throws<IndexOutOfRangeException>(() => new IMAGE_BASE_RELOCATION(RawStructures.RawImageBaseRelocation, 1234, 12));
        }

        [Fact]
        public void ImageBaseRelocationConstructorWorks_Test()
        {
            var ibr = new IMAGE_BASE_RELOCATION(RawStructures.RawImageBaseRelocation, 2, 12);

            Assert.Equal((uint) 0x10000, ibr.VirtualAddress);
            Assert.Equal((uint) 0xc, ibr.SizeOfBlock);
            Assert.Equal(2, ibr.TypeOffsets.Length);
            Assert.Equal(0x2211 >> 12, ibr.TypeOffsets[0].Type);
            Assert.Equal(0x2211 & 0xfff, ibr.TypeOffsets[0].Offset);
            Assert.Equal(0x4433 >> 12, ibr.TypeOffsets[1].Type);
            Assert.Equal(0x4433 & 0xfff, ibr.TypeOffsets[1].Offset);
        }
    }
}