using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hook.Searcher
{
    static class Searcher
    {
        public static int Search(byte[] content, byte[] match, int entryPoint)
        {
            for (int i = entryPoint; i <= content.Length - match.Length; i++)
            {
                bool found = true;

                for (int m = 0; m < match.Length; m++)
                {
                    if (content[i + m] != match[m])
                    {
                        found = false;
                        break;
                    }
                }

                if (found)
                {
                    return i;
                }

            }

            return -1;
        }

        public static int CountMatches(byte[] content, byte[] match)
        {
            int matches = 0;

            for (int i = 0; i <= content.Length - match.Length; i++)
            {
                bool found = true;

                for (int m = 0; m < match.Length; m++)
                {
                    if (content[i + m] != match[m])
                    {
                        found = false;
                        break;
                    }
                }

                if (found)
                    matches++;

            }

            return matches;
        }

        public static int FindBytes(byte[] src, byte[] find)
        {
            int index = -1;
            int matchIndex = 0;
            for (int i = 0; i < src.Length; i++)
            {
                if (src[i] == find[matchIndex])
                {
                    if (matchIndex == (find.Length - 1))
                    {
                        index = i - matchIndex;
                        break;
                    }
                    matchIndex++;
                }
                else
                {
                    matchIndex = 0;
                }

            }
            return index;
        }

        public static byte[] ReplaceBytes(byte[] src, byte[] search, byte[] repl, out bool changed)
        {
            byte[] dst = null;
            changed = false;
            int index = FindBytes(src, search);
            if (index >= 0)
            {
                changed = true;
                dst = new byte[src.Length - search.Length + repl.Length];
                Buffer.BlockCopy(src, 0, dst, 0, index);
                Buffer.BlockCopy(repl, 0, dst, index, repl.Length);
                Buffer.BlockCopy(
                    src,
                    index + search.Length,
                    dst,
                    index + repl.Length,
                    src.Length - (index + search.Length));
            }

            if (dst == null)
                return src;
            return dst;
        }
    }
}
