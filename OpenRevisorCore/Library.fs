namespace OpenRevisorCore


module Questions =
    
    /// Represents a question with a text and an answer.
    type Question = { Text: string; Answer: string }

    /// <summary>
    /// Checks if the given answer is correct for the given question.
    /// </summary>
    /// <param name="question">The question that is being answered.</param>
    /// <param name="givenAnswer">The answer that needs to be checked.</param>
    /// <returns>True if the answer matches, false otherwise.</returns>
    let isCorrect (question: Question) (givenAnswer: string) =
        question.Answer.Equals(givenAnswer, System.StringComparison.OrdinalIgnoreCase)