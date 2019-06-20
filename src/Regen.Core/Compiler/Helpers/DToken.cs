﻿using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Regen.Compiler.Digest;

namespace Regen.Compiler.Helpers {
    [DebuggerDisplay("{DigestToken} - {Match}")]
    public class DToken {
        public DigestToken DigestToken { get; set; }
        public Match Match { get; set; }

        public DToken() { }

        public DToken(DigestToken digestToken, Match match) {
            DigestToken = digestToken;
            Match = match ?? throw new ArgumentNullException(nameof(match));
        }
    }
}