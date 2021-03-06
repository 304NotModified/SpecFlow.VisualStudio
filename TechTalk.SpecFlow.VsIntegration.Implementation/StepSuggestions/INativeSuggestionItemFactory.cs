﻿namespace TechTalk.SpecFlow.VsIntegration.Implementation.StepSuggestions
{
    public interface INativeSuggestionItemFactory<TNativeSuggestionItem>
    {
        TNativeSuggestionItem Create(string displayText, string insertionText, int level, string icon, object parentObject);
        TNativeSuggestionItem CloneTo(TNativeSuggestionItem nativeSuggestionItem, object parentObject);
        string GetInsertionText(TNativeSuggestionItem nativeSuggestionItem);
        int GetLevel(TNativeSuggestionItem nativeSuggestionItem);
    }
}