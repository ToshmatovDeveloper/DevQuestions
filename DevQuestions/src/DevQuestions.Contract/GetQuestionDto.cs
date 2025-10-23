namespace DevQuestions.Contract;

public record GetQuestionDto(string Search, Guid[] TagIds, int Page, int PageSize);