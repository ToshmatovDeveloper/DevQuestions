namespace DevQuestions.Contract;

public record CreateQuestionDto(string Title, string Body, Guid UserIds, Guid[] TagIds);