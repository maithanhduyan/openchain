﻿// Copyright 2015 Coinprism, Inc.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace OpenChain.Ledger
{
    /// <summary>
    /// Represents a digital signature.
    /// </summary>
    public class SignatureEvidence
    {
        public SignatureEvidence(ByteString publicKey, ByteString signature)
        {
            this.PublicKey = publicKey;
            this.Signature = signature;
        }

        /// <summary>
        /// Gets the public key corresponding to the signature.
        /// </summary>
        public ByteString PublicKey { get; }

        /// <summary>
        /// Gets the digital signature.
        /// </summary>
        public ByteString Signature { get; }
    }
}
