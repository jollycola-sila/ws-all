﻿using System.ComponentModel.DataAnnotations;

namespace BoosterConf.Ef.Ninja.Database.Entities;

public class ClaimStatusEntity
{
    public int Id { get; set; }
    public required Guid ExternalId { get; set; }

    [MaxLength(length: 128)]
    public required string Name { get; set; }

    [MaxLength(length: 512)]
    public required string Description { get; set; }
}
