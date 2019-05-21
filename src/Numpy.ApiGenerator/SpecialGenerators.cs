﻿using System;
using System.Collections.Generic;
using System.Text;
using CodeMinion.Core.Helpers;

namespace Torch.ApiGenerator
{
    public static class SpecialGenerators
    {

        public static void GenNDArrayToPython(CodeWriter s)
        {
            s.Out("protected PyObject NDArrayToPython(NDArray nd)", () =>
            {
                s.Out("// todo: MarshalCopy");
                s.Out("var result = np.array(new PyTuple(new[] { ToTuple(nd.Array) }));");
                s.Out("if (nd.ndim == 0)", () =>
                {
                    s.Out("throw new NotImplementedException(\"Are Scalars supported here ? \");");
                });
                s.Out("if (nd.ndim > 1)", () =>
                {
                    s.Out("result = np.reshape(result, nd.shape.ToList<int>());");
                });
                s.Out("return result;");
            });
        }

        public static void InitNumpyGenerator(CodeWriter s)
        {
            s.Out("var installer = new Installer();");
            s.Out("installer.SetupPython().Wait();");
            s.Out("installer.InstallWheel(this.GetType().Assembly, \"numpy-1.16.3-cp37-cp37m-win_amd64.whl\").Wait();");
        }
    }
}
