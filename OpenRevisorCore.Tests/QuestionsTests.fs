namespace OpenRevisorCore.Tests

open Xunit
open OpenRevisorCore.Questions

module QuestionsTests =

    [<Fact>]
    let ``createQuestion should create a question with given text and answer`` () =
        let text = "What is F#?"
        let answer = "A functional programming language"
        let question = createQuestion text answer
        Assert.Equal(text, getText question)
        Assert.True(isCorrect question answer)

    [<Fact>]
    let ``getText should return the text of the question`` () =
        let text = "What is F#?"
        let answer = "A functional programming language"
        let question = createQuestion text answer
        let result = getText question
        Assert.Equal(text, result)

    [<Fact>]
    let ``isCorrect should return true for correct answer`` () =
        let text = "What is F#?"
        let answer = "A functional programming language"
        let question = createQuestion text answer
        let result = isCorrect question answer
        Assert.True(result)

    [<Fact>]
    let ``isCorrect should return false for incorrect answer`` () =
        let text = "What is F#?"
        let answer = "A functional programming language"
        let question = createQuestion text answer
        let result = isCorrect question "An object-oriented language"
        Assert.False(result)