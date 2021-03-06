// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.ComponentModel;

namespace osu.Game.Configuration
{
    public enum ScoreMeterType
    {
        [Description("None")]
        None,

        [Description("Hit Error (left)")]
        HitErrorLeft,

        [Description("Hit Error (right)")]
        HitErrorRight,

        [Description("Hit Error (left+right)")]
        HitErrorBoth,

        [Description("Hit Error (bottom)")]
        HitErrorBottom,

        [Description("Colour (left)")]
        ColourLeft,

        [Description("Colour (right)")]
        ColourRight,

        [Description("Colour (left+right)")]
        ColourBoth,

        [Description("Colour (bottom)")]
        ColourBottom,
    }
}
