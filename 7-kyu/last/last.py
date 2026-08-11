def last(*items):
    if len(items)>1:
        return items[-1]
    arg = items[0]
    if isinstance(items[0], str):
        split_string = list(arg)
        return split_string[-1]
    elif isinstance(arg, list):
        return arg[-1]
    return items[-1]
    
    
        