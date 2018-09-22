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

using Xunit;
using PeNet.Structures;

namespace PeNet.UnitTest.Structures
{
    
    public class IMAGE_COR20_HEADER_Test
    {
        [Fact]
        public void ImageCor20HeaderConstructorWorks_Test()
        {
            var imageCor20Header = new IMAGE_COR20_HEADER(RawDotNetStructures.RawImageCor20Header, 3);

            Assert.Equal((uint) 0x33221100, imageCor20Header.cb);
            Assert.Equal((uint) 0x5544, imageCor20Header.MajorRuntimeVersion);
            Assert.Equal((uint) 0x7766, imageCor20Header.MinorRuntimeVersion);
            Assert.Equal((uint) 0xbbaa9988, imageCor20Header.MetaData.VirtualAddress);
            Assert.Equal((uint) 0xffeeddcc, imageCor20Header.MetaData.Size);
            Assert.Equal((uint) 0x44332211, imageCor20Header.Flags);
            Assert.Equal((uint) 0x88776655, imageCor20Header.EntryPointToken);
            Assert.Equal((uint) 0x88776655, imageCor20Header.EntryPointRVA);
            Assert.Equal((uint) 0xccbbaa99, imageCor20Header.Resources.VirtualAddress);
            Assert.Equal((uint) 0x11ffeedd, imageCor20Header.Resources.Size);
            Assert.Equal((uint) 0xddccbbaa, imageCor20Header.StrongNameSignature.VirtualAddress);
            Assert.Equal((uint) 0x2211ffee, imageCor20Header.StrongNameSignature.Size);
            Assert.Equal((uint) 0xeeddccbb, imageCor20Header.CodeManagerTable.VirtualAddress);
            Assert.Equal((uint) 0x332211ff, imageCor20Header.CodeManagerTable.Size);
            Assert.Equal((uint) 0xffeeddcc, imageCor20Header.VTableFixups.VirtualAddress);
            Assert.Equal((uint) 0x44332211, imageCor20Header.VTableFixups.Size);
            Assert.Equal((uint) 0x11ffeedd, imageCor20Header.ExportAddressTableJumps.VirtualAddress);
            Assert.Equal((uint) 0x55443322, imageCor20Header.ExportAddressTableJumps.Size);
            Assert.Equal((uint) 0x2211ffee, imageCor20Header.ManagedNativeHeader.VirtualAddress);
            Assert.Equal((uint) 0x66554433, imageCor20Header.ManagedNativeHeader.Size);
        }
    }
}