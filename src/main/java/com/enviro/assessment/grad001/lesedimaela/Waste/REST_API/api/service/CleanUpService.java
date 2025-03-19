package com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.service;

import com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.model.CleanUp;
import com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.repo.CleanUpRepo;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
public class CleanUpService extends com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.service.Service<CleanUp> {

    @Autowired
    private CleanUpRepo cleanUpRepo;

    public List<CleanUp> getAll(){

        return cleanUpRepo.findAll();
    }

    public Optional<CleanUp> getByID(Long id){

        return cleanUpRepo.findById(id);
    }

    public void deleteByID(Long id){

        cleanUpRepo.deleteById(id);
    }

    public CleanUp update(Long id, CleanUp newCleanUp) {

        Optional<CleanUp> oldCleanUp = getByID(id);

        if (oldCleanUp.isPresent()) {

            if (newCleanUp.getCollectedJunk() > oldCleanUp.get().getCollectedJunk()) {
                CleanUp updatedCleanup = oldCleanUp.get();
                updatedCleanup.setLocation(newCleanUp.getLocation());
                updatedCleanup.setDescription(newCleanUp.getDescription());
                updatedCleanup.setTotalJunk(newCleanUp.getTotalJunk());
                updatedCleanup.setCollectedJunk(newCleanUp.getCollectedJunk());

                CleanUp cleanUpData = save(updatedCleanup);

                return cleanUpData;
            }
        }
        return null;
    }

    public CleanUp save(CleanUp cleanUp){

        cleanUp.setLocation(cleanUp.getLocation().toLowerCase());
        CleanUp cleanUpData = cleanUpRepo.save(cleanUp);

        return cleanUpData;
    }
}
