// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Game.Rulesets;

namespace osu.Game.Overlays.KeyBinding
{
    public class VariantBindingsSubsection : KeyBindingsSubsection
    {
        protected override string Header { get; }

        public VariantBindingsSubsection(RulesetInfo ruleset, int variant)
            : base(variant)
        {
            Ruleset = ruleset;

            var rulesetInstance = ruleset.CreateInstance();

            Header = rulesetInstance.GetVariantName(variant);
            Defaults = rulesetInstance.GetDefaultKeyBindings(variant);
        }
    }
}
