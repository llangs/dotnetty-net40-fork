﻿#if NET40
namespace DotNetty.Buffers
{
    partial class UnpooledDuplicatedByteBuffer
    {
        public override ref byte GetPinnableMemoryOffsetAddress(int elementOffset)
        {
            return ref this.Unwrap().GetPinnableMemoryOffsetAddress(elementOffset);
        }
    }
}
#endif
