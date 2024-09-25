workers = [
    {
        'id': 1,
        'job_title': 'junior developer',
        'name': 'John',
        'programming_languages': ['python']
    },
    {
        'id': 2,
        'job_title': 'senior developer',
        'name': 'Mark',
        'programming_languages': ['python', 'php']
    },
    {
        'id': 3,
        'job_title': 'stuff developer',
        'name': 'Alex',
        'programming_languages': ['python', 'php', 'javascript']
    },
    {
        'id': 4,
        'job_title': 'junior developer',
        'name': 'Bart',
        'programming_languages': ['javascript', 'php']
    },
    {
        'id': 5,
        'job_title': 'senior developer',
        'name': 'Carl',
        'programming_languages': ['python']
    },
    {
        'id': 6,
        'job_title': 'junior developer',
        'name': 'Martha',
        'programming_languages': ['javascript', 'php']
    },
]

statistics = {}

for worker in workers:
    for programing_language in worker['programming_languages']:
        if programing_language not in statistics:
            statistics[programing_language] = {
                'quantity': 0,
                'names': []
            }

        statistics[programing_language]['quantity'] += 1
        statistics[programing_language]['names'].append(worker['name'])

print(statistics)
