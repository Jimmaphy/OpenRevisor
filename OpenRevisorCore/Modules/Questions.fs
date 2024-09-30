namespace OpenRevisorCore

open System

module Questions =
    
    /// Represents a hidden question with a text and and answer.
    type Question = private { Text: string; Answer: string }

    /// Represents possible errors when creating a question.
    type QuestionError =
        | EmptyText
        | EmptyAnswer

    /// <summary>
    /// Create a new question with the given text and answer.
    /// </summary>
    /// <param name="text">The text of the question.</param>
    /// <param name="answer">The answer to the question.</param>
    /// <returns>A new question with the given text and answer.</returns>
    let createQuestion text answer =
        match (String.IsNullOrWhiteSpace(text), String.IsNullOrWhiteSpace(answer)) with
        | true, _ -> Error EmptyText
        | _, true -> Error EmptyAnswer
        | _ -> Ok { Text = text; Answer = answer }

    /// <summary>
    /// Get the text of a question.
    /// </summary>
    /// <param name="question">The question to get the text from.</param>
    /// <returns>The text of the question.</returns>
    let getText question = 
        question.Text

    /// <summary>
    /// Checks if the given answer is correct for the given question.
    /// </summary>
    /// <param name="question">The question that is being answered.</param>
    /// <param name="givenAnswer">The answer that needs to be checked.</param>
    /// <returns>True if the answer matches, false otherwise.</returns>
    let isCorrect question givenAnswer =
        question.Answer.Equals(givenAnswer, System.StringComparison.OrdinalIgnoreCase)