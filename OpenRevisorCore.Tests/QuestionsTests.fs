namespace Jimmaphy.OpenRevisorCore.Tests

open Xunit
open Jimmaphy.OpenRevisorCore.Questions

module QuestionsTests =

    module CreateQuestionTests = 

        [<Fact>]
        let ``createQuestion should return Error EmptyText when text is empty`` () =
            let text = ""
            let answer = "A functional programming language"
            let result = createQuestion text answer
            match result with
            | Error EmptyText -> Assert.True(true)
            | _ -> Assert.True(false, "Expected Error EmptyText")

        [<Fact>]
        let ``createQuestion should return Error EmptyAnswer when answer is empty`` () =
            let text = "What is F#?"
            let answer = ""
            let result = createQuestion text answer
            match result with
            | Error EmptyAnswer -> Assert.True(true)
            | _ -> Assert.True(false, "Expected Error EmptyAnswer")

        [<Fact>]
        let ``createQuestion should return Ok when text and answer are non-empty`` () =
            let text = "What is F#?"
            let answer = "A functional programming language"
            let result = createQuestion text answer
            match result with
            | Ok question -> 
                Assert.Equal(text, getText question)
                Assert.True(isCorrect question answer)
            | _ -> Assert.True(false, "Expected Ok result")


    module GetTextTests = 

        [<Fact>]
        let ``getText should throw exception for invalid question`` () =
            let text = "What is F#?"
            let answer = "A functional programming language"
            let question = createQuestion text answer
            match question with
            | Ok validQuestion -> 
                let result = getText validQuestion
                Assert.Equal(text, result)
            | Error _ -> Assert.True(false, "Expected Ok result")

    
    module IsCorrectTests =
        [<Fact>]
        let ``isCorrect should be case insensitive`` () =
            let text = "What is F#?"
            let answer = "A functional programming language"
            let question = createQuestion text answer
            match question with
            | Ok validQuestion -> 
                let result = isCorrect validQuestion "a functional programming language"
                Assert.True(result)
            | Error _ -> Assert.True(false, "Expected Ok result")

        [<Fact>]
        let ``isCorrect should return false for partially correct answer`` () =
            let text = "What is F#?"
            let answer = "A functional programming language"
            let question = createQuestion text answer
            match question with
            | Ok validQuestion -> 
                let result = isCorrect validQuestion "A functional"
                Assert.False(result)
            | Error _ -> Assert.True(false, "Expected Ok result")